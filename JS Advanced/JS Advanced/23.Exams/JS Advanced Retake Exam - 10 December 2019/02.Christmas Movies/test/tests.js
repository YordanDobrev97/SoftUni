const ChristmasMovies = require('../02.ChristmasMoviesResources');
const expect = require('chai').expect;

describe('tests', function() {
    let movie;

    this.beforeEach(() => {
        movie = new ChristmasMovies();
    });

    describe('test buy movie functionality', function() {
        it('add movie in collection', function() {
            const movieData = {
                name: 'Home Alone 5',
                actors: ['Jodelle Ferland']
            };
            const result = movie.buyMovie(movieData.name, movieData.actors);
            expect(result).to.be.equal(`You just got Home Alone 5 to your collection in which Jodelle Ferland are taking part!`);
        });
    
        it('throw error add exist movie', function() {
            const movieData = {
                name: 'Home Alone',
                actors: []
            };
            movie.buyMovie(movieData.name, movieData.actors);
            const result = () => movie.buyMovie(movieData.name, movieData.actors);
            expect(result).to.throw(Error,  "You already own Home Alone in your collection!");
        });
    });

    describe('test watched movie', function(){
        it ('add movie for watched', function(){
            movie.buyMovie('Home Alone');
            const result = movie.watchMovie('Home Alone');
            const watch =movie.watched.hasOwnProperty('Home Alone'); 
            expect(watch).to.be.equal(true);
        });

        it ('No such movie in your collection', function(){
            const result = () => movie.watchMovie('Home Alone 2');
            expect(result).to.throw(Error, 'No such movie in your collection!');
        })    
    });

    describe('test discard move', function() {
        it('filtered with not exist movie', function(){
            const movieData = {
                name: 'Anabel',
                actors: ['Annabelle Wallis', 'Ward Horton']
            };
            const result =() => movie.discardMovie(movieData.name);
            expect(result).to.throw(Error, 'Anabel is not at your collection!')
        });

        it ('throw error not watched movie', function() {
            movie.buyMovie('Home Alone 5', ['Jodelle Ferland']);
            const result = () => movie.discardMovie('Home Alone 5');
            expect(result).to.throw(Error, 'Home Alone 5 is not watched!');
        });

        it ('You just threw away', function(){
            movie.buyMovie('Home Alone');
            movie.watchMovie('Home Alone');
            const watchMovie = movie.discardMovie('Home Alone');
            expect(watchMovie).to.be.equal('You just threw away Home Alone!');
        });
    });

    describe('test most starred actor', function(){
        it ('not watched a movie yet this year', function(){
            const result = () => movie.mostStarredActor();
            expect(result).to.throw(Error, 'You have not watched a movie yet this year!');
        });
    });

    describe('test favourite movie', function() {
        it ('not watched', function(){
            const result = () => movie.favouriteMovie();
            expect(result).to.throw(Error, 'You have not watched a movie yet this year!');
        });

        it ('favourite movies', function(){
            movie.buyMovie('Anabel', ['dont know']);
            movie.watchMovie('Anabel');
            const result = movie.favouriteMovie();
            expect(result).to.be.equal(`Your favourite movie is Anabel and you have watched it 1 times!`)
        });
    });
});

