import helper from '../utils/helper.js';
import models from '../models/cause.js';

export default {
    get: {
       async home(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs')
            }

            helper.setCredentials(context);

            await models.cause.getAll().then((response) => {
                const articles = response.docs.map(helper.getDataWithId);

                const cSharpArticles = [...articles].filter(c => c.category === 'C#');
                const javaScriptArticles = [...articles].filter(c => c.category === 'JavaScript');
                const pythonArticles =  [...articles].filter(c => c.category === 'Python');
                const javaArticles =  [...articles].filter(c => c.category === 'Java');

                if (cSharpArticles.length > 0) {
                    context.hasArticlesCSharp = true;
                    context.articlesCSharp = cSharpArticles;
                }
                
                if (javaScriptArticles.length > 0) {
                    context.hasArticlesForJs = true;
                    context.articlesJavaScript = javaScriptArticles;
                }
                
                if (pythonArticles.length > 0) {
                    context.hasArticlesForPython = true;
                    context.articlesPython = pythonArticles;
                }

                if (javaArticles.length > 0) {
                    context.hasArticlesForJava = true;
                    context.articlesJava = javaArticles;
                }

                console.log(articles);
                this.partial('../views/home/home.hbs');
             });           
        }
    }
}