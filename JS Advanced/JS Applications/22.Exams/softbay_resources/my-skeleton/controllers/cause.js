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
            context.id = sessionStorage.getItem('id');
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

            context.product = currentCause.product;
            context.description = currentCause.description;
            context.pictureUrl = currentCause.pictureUrl;
            context.price = currentCause.price;

            this.partial('../views/cause/details.hbs');
        }
    },
    post: {
        create(context) {
            const {product, description, price, pictureUrl} = this.params;

            models.cause.create({product, description, price, pictureUrl})
                .then(response => {
                    const id = response.id;
                    sessionStorage.setItem('id', id);
                    console.log(response);
                    context.redirect('#/home');
                });
        },
    },
    edit:{
        async edit(context) {
            console.log('work');
        }
    },
    del: {
        async remove(context) {
            const {id} = context.params;
            await models.cause.remove(id);
            context.redirect('#/dashboard');
        }
    }
}