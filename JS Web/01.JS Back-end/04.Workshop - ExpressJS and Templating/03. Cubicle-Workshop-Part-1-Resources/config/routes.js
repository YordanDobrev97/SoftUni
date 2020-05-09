// TODO: Require Controllers...
const controllers = require('../controllers/index.js');

module.exports = (app) => {
    app.get('/', (req, res) => {
        res.render('index', {layout: false});
    });

    app.get('/create', (req, res) => {
        res.render('create', {layout: false});
    });

    app.get('/about', (req, res) => {
        res.render('about', {layout: false});
    })
};
