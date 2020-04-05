import models from '../models/index.js';
import helper from '../utils/helper.js';

export default {
    get: {
        async login(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs'),
            }
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
           console.log(this.params)
           models.user.login(username, password)
            .then(response => {
                sessionStorage.setItem('userId', response.user.uid);
                //sessionStorage.setItem('first', response.user.email);

                context.redirect('#/home')
            });
        },
        register(context) {
            const {username, password, rePassword} = this.params;
            
            if (password !== rePassword) {
                //TODO notifications
                return;
            }

            models.user.register(username, password)
                .then(response => {
                    //sessionStorage.setItem('userId', response.user.uid);
                    //sessionStorage.setItem('username', response.user.email);
                    //const fullName = `${context.params.firstName}${context.params.lastName}`
                    //sessionStorage.setItem('fullname', fullName)
                    context.redirect('#/login');
            });
        }
    },
    edit: {
        async edit(context) {
            context.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs'),
            }

            helper.setCredentials(context);

            await context.partial('../views/cause/edit.hbs');
        }
    }
}