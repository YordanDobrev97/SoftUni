
export default function extend(context) {
    firebase().auth().onAuthStateChanged(function(user){
        if (user) {
            context.isLogin = true;
            //TODO...
        } else {
            //TODO..
            context.isLogin = false;
        }
    });

    return context.loadPartials({
        header: '../templates/common/header.hbs',
        footer: '../templates/common/footer.hbs'
    });
}