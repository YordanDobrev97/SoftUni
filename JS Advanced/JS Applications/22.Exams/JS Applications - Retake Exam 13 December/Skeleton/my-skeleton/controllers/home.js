import helper from '../utils/helper.js';

export default {
    get: {
       async home(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs')
            }

            // this.isLogin = !!sessionStorage.getItem('userId');
            // this.username = sessionStorage.getItem('username');
            helper.setCredentials(context);

            this.partial('../views/home/home.hbs');
        }
    }
}