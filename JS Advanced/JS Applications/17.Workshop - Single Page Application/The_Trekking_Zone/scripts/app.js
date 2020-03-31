import controllers from '../controllers/index.js';

const app = Sammy('#root', function () {

    this.use('Handlebars', 'hbs');

    //Home
    this.get('#/home', controllers.home.get.home);

    //User
    this.get('#/user/login', controllers.user.get.login);
    this.get('#/user/register', controllers.user.get.register);

    this.post('#/user/login', controllers.user.post.login);
    this.post('#/user/register', controllers.user.post.register);
    this.get('#/user/logout', controllers.user.get.logout);

    //Cause
    this.get('#/cause/dashboard', controllers.cause.get.dashboard);
    this.get('#/cause/create', controllers.cause.get.create);
    this.get('#/cause/details/:causeId', controllers.cause.get.details);
    this.get('#/cause/close/:causeId', controllers.cause.del.close);
    this.get('#/cause/edit/:causeId', controllers.cause.get.edit);
    this.get('#/cause/like/:causeId', controllers.cause.put.like);

    this.post('#/cause/create', controllers.cause.post.create);

    // Тук се опитвам да едитна трека, но нямам id, което да използвам в темплейта ./views/cause/edit.hbs
    //От къде да взема id и къде да го закача, така че да мога да го използвам тук? 
    this.post('#/cause/edit/:causeId', controllers.cause.put.edit);


});

(() => {
    app.run('#/home');
})();