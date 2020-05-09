const express = require('express');
const handlebars = require('express-handlebars');
const bodyParser = require('body-parser');
const router = require('./routes.js');

module.exports = (app) => {

    app.engine('hbs', handlebars());
    app.set('view engine', 'hbs');
    app.use(express.static('views'));
    app.use(express.static('static'));
    app.use(bodyParser.urlencoded({ extended: true }));

    router(app);
};