import models from '../models/index.js';
import helper from '../utils/helper.js';

export default {
    get: {
        async login(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs'),
            }
            helper.setCredentials(context);
            
            await this.partial('../views/user/login-form.hbs');
        },
        async register(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs'),
            }

            await this.partial('../views/user/register-form.hbs');
        },
        async logout(context) {
            models.user.logout();
            context.redirect('#/login');
        }
    },
    post: {
        login(context) {
           const {email, password} = this.params;
           models.user.login(email, password)
            .then(response => {
                sessionStorage.setItem('userId', response.user.uid);
                sessionStorage.setItem('username', response.user.email);

                context.redirect('#/home')
            });
        },
        register(context) {
            const {email, password, repPass} = this.params;
            console.log(this.params);
            if (password != repPass) {
                //TODO notifications
                return;
            }

            models.user.register(email, password)
                .then(response => {
                    context.redirect('#/login');
            });
        }
    }
}