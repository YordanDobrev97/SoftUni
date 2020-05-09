// TODO: Require Controllers...
const controllers = require('../controllers/index.js');
const cubes = require('./database.json');

module.exports = (app) => {
    app.get('/', (req, res) => {
        res.render('index', {layout: false, cubes: cubes});
    });

    app.get('/create', (req, res) => {
        res.render('create', {layout: false});
    });

    app.get('/about', (req, res) => {
        res.render('about', {layout: false});
    })
};
