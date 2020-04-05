import controllers from '../controllers/index.js'

const app = Sammy('#root', function(){
    this.use('Handlebars', 'hbs');

    this.get('#/home', controllers.home.get.home);
    this.get('#/login', controllers.user.get.login);
    this.get('#/register', controllers.user.get.register);
    this.get('#/create', controllers.cause.get.create);
    this.get('#/logout', controllers.user.get.logout);
    this.get('#/logout', controllers.user.get.logout);
    this.get('#/dashboard', controllers.cause.get.dashboard);
    this.get('#/details/:id', controllers.cause.get.details);
    this.get('#/delete/:id', controllers.cause.del.remove);
    this.get('#/edit/:id', controllers.user.edit.edit);

    this.post('#/register', controllers.user.post.register);
    this.post('#/create', controllers.cause.post.create);
    this.post('#/login', controllers.user.post.login);
    this.post('#/edit/:id', controllers.cause.edit.edit);
    
});

(() => {
    app.run('#/home');
})();