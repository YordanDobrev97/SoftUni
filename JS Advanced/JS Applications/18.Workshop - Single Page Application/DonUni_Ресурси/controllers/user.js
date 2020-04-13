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
            context.redirect('#/home');
        }
    },
    post: {
        login(context) {
           const {username, password} = this.params;
           models.user.login(username, password)
            .then(response => {
                localStorage.setItem('userId', response.uid);
                localStorage.setItem('username', response.user.email);

                context.redirect('#/home')
            });
        },
        register(context) {
            const {username, password, rePassword} = this.params;
            
            if (password != rePassword) {
                //TODO notifications
                return;
            }

            models.user.register(username, password)
                .then(response => {
                    context.redirect('#/home');
            });
        }
    }
}