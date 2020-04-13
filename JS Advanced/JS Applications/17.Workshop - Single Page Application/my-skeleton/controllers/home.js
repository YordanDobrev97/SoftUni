import helper from '../utils/helper.js';
import models from '../models/cause.js';

export default {
    get: {
       async home(context) {
            this.partials = {
                header: await context.load('../views/common/headers.hbs'),
                footer: await context.load('../views/common/footer.hbs')
            }

            const resultData = await models.cause.getAll().then((response) => {
                const treks = response.docs.map(helper.getDataWithId);
                return treks;
             });

             context.hasCauses = true;
             context.treks = resultData;

            // this.isLogin = !!sessionStorage.getItem('userId');
            // this.username = sessionStorage.getItem('username');
            helper.setCredentials(context);

            this.partial('../views/home/home.hbs');
        }
    }
}