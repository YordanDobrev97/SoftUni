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

    app.post('/create', (req, res) => {
        const {name, description, imageUrl, difficultyLevel} = req.body;

        cubes.push({
            name,
            description,
            image: imageUrl,
            level: difficultyLevel
        });

        res.redirect('/');
    })

    app.get('/about', (req, res) => {
        res.render('about', {layout: false});
    })
};
