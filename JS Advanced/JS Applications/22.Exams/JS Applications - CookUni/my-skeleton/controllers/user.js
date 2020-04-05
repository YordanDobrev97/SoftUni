import models from '../models/index.js';

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
           models.user.login(username, password)
            .then(response => {
                console.log(response);
                sessionStorage.setItem('userId', response.uid);
                //sessionStorage.setItem('first', response.user.email);

                context.redirect('#/home')
            });
        },
        register(context) {
            const {username, password, repeatPassword} = this.params;
            
            if (password !== repeatPassword) {
                //TODO notifications
                return;
            }

            models.user.register(username, password)
                .then(response => {
                    sessionStorage.setItem('userId', response.user.uid);
                    sessionStorage.setItem('username', response.user.email);
                    const fullName = `${context.params.firstName}${context.params.lastName}`
                    sessionStorage.setItem('fullname', fullName)
                    context.redirect('#/home');
            });
        }
    }
}