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
               const treks = response.docs.map(helper.getDataWithId);
               context.causes = treks;

               this.partial('../views/cause/dashboard.hbs');
               console.log(treks);
            });
        },
        async details(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs'),
            }
            helper.setCredentials(context);

            const {id} = this.params;
            const currentCause = await models.cause.getById(id).then(response => {
                const cause = helper.getDataWithId(response);
                return cause;
            });
            
            context.location = currentCause.location;
            context.description = currentCause.description;
            context.imageURL = currentCause.imageURL;
            context.dateTime = currentCause.dateTime;

            this.partial('../views/cause/details.hbs');
        },
        async remove(context) {
            console.log(context);
        }
    },
    post: {
        create(context) {
            const {location, dateTime, description, imageURL} = this.params;
            const data = {location, dateTime, description, imageURL};
            console.log(data);
            models.cause.create(data).then(() => {
                context.redirect('#/home');
            });
        }
    }
}