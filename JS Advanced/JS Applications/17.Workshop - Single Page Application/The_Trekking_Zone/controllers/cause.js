import extend from '../utils/context.js';
import models from '../models/index.js';
import docModifier from '../utils/doc-modifier.js'
import fillFormWithData from '../utils/formFiller.js'

export default {
    get: {
        dashboard(context) {

            models.cause.getAll().then(response => {
                const treks = response.docs.map(docModifier);
                context.treks = treks;

                extend(context).then(function () {
                    this.partial('../views/cause/dashboard.hbs');
                });
            })
        },
        create(context) {
            extend(context).then(function () {
                this.partial('../views/cause/create.hbs');
            });
        },
        details(context) {
            const { causeId } = context.params;

            models.cause.get(causeId).then(response => {

                const trek = docModifier(response);
                Object.keys(trek).forEach(key => context[key] = trek[key]);

                context.canLike = trek.uid !== localStorage.getItem('userId');

                extend(context).then(function () {
                    this.partial('../views/cause/details.hbs');
                });

            })
                .catch(e => console.error(e));
        },
        edit(context) {
            extend(context).then(function () {
                this.partial('../views/cause/edit.hbs');
            });

            const { causeId } = context.params;
            localStorage.setItem('trekId', causeId);

            models.cause.get(causeId).then(response => {
                const formValues = response.data();
                const formRef = document.querySelector('form');
                fillFormWithData(formRef, formValues);
            });

        }
    },
    post: {
        create(context) {

            console.log(context.params);
            const data = {
                ...context.params,
                uid: localStorage.getItem('userId'),
                organizer: localStorage.getItem('userEmail'),
                likes: 0
            }

            models.cause.create(data)
                .then(response => {
                    context.redirect('#/cause/dashboard');
                })
                .catch(e => console.error(e));
        }

    },
    del: {
        close(context) {
            const { causeId } = context.params;
            models.cause.close(causeId).then(response => {
                context.redirect('#/cause/dashboard');
            })
                .catch(e => console.error(e));
        }
    },
    put: {
        like(context) {
            const { causeId } = context.params;

            models.cause.get(causeId).then(response => {
                const trek = docModifier(response);
                trek.likes += 1;

                return models.cause.like(causeId, trek);
            })
                .then(response => {
                    context.redirect(`#/cause/details/${causeId}`);
                })
        },
        edit(context) {

            //TODO... 
            const {causeId} = context.params;
            console.log(context.params);
        }
    }
}