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
               const ideas = response.docs.map(helper.getDataWithId);
               context.ideas = ideas;

               this.partial('../views/cause/dashboard.hbs');
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
            const currentCause = await models.cause.getById(id).then(response => {
                const cause = helper.getDataWithId(response);
                return cause;
            });
           
            context.title = currentCause.title;
            context.description = currentCause.description;
            context.imageURL = currentCause.imageURL;
            context.likes = currentCause.likes;

            this.partial('../views/cause/details.hbs');
        },
    },
    post: {
        create(context) {
            const {title, description, imageURL} = this.params;
            const data = {likes: 0, title: title, description: description, imageURL: imageURL};
           
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
            
            context.redirect('#/dashboard');
        }
   }
}