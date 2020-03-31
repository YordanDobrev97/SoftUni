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
            models.cause.getAll().then(response => {
                const causes = response.docs.map(helper.getDataWithId);
                context.causes = causes;
                console.log(causes);
                this.partial('../views/cause/dashboard.hbs');
            })
        },
        async details(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs')
            }
            helper.setCredentials(context);
           const {id} = this.params;

            const currentCause = await models.cause.getById(id).then(response => {
                const cause = helper.getDataWithId(response);
                return cause;
            });
            context.cause = currentCause.cause;
            context.description = currentCause.description;
            context.pictureUrl = currentCause.pictureUrl;
            context.neededFunds = currentCause.neededFunds;
            context.currentFunds = currentCause.currentFunds;
            context.donors = currentCause.donors;
            console.log(currentCause);

            this.partial('../views/cause/details.hbs');
        }
    },
    post: {
        create(context) {
            const {cause, pictureUrl, neededFunds, description} = this.params;
            models.cause.create({cause, pictureUrl, neededFunds, description, currentFunds: 0, donors: []})
                .then(response => {
                    context.redirect('#/home');
                });
        },
        remove(context) {
            console.log('work');
        }
    }
}