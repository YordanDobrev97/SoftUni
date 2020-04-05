import models from '../models/cause.js';
import helper from '../utils/helper.js';

export default {
    get: {
        async create(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs')
            }

            helper.setCredentials(context);
            this.partial('../views/cause/create.hbs');
        },
        async dashboard(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs')
            }

            helper.setCredentials(context);
           
            models.cause.getAll().then((response) => {
               const articles = response.docs.map(helper.getDataWithId);
               context.ideas = articles;
                console.log(articles);
               //this.partial('../views/cause/dashboard.hbs');
            });
        },
        async details(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs'),
            }
            helper.setCredentials(context);

            const {id} = this.params;
            context.id = id;
            const currentData = await models.cause.getById(id).then(response => {
                const cause = helper.getDataWithId(response);
                return cause;
            });
           
            context.title = currentData.title;
            context.category = currentData.category;
            context.content = currentData.content;
            context.isCreator = sessionStorage.getItem('userId') === currentData.userId;

            this.partial('../views/cause/details.hbs');
        },
    },
    post: {
        create(context) {
            const userId = sessionStorage.getItem('userId');
            const {title, category, content} = this.params;

            const data = {
                creator: sessionStorage.getItem('username'),
                title: title, 
                category: category, 
                content: content,
                userId: userId
            };
           
            models.cause.create(data).then((response) => {
                const id = response.id;
                sessionStorage.setItem('id', id);
                context.redirect('#/home');
            });
        }
    },
   del: {
        async delete(context) {
            const {id} = this.params;
            
            await models.cause.remove(id);
            
            context.redirect('#/home');
        }
   },
   edit: {
       async getEdit(context) {
            context.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs'),
            }

            helper.setCredentials(context);
            context.id = sessionStorage.getItem('id');

            this.partial('../views/cause/edit.hbs');
       },
       async postEdit(content) {
           console.log('work post')
       }
   }
}