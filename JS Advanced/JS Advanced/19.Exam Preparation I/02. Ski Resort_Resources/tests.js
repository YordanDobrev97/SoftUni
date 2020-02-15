const expect = require('chai').expect;
let SkiResort = require('./solution');

describe('SkiResort', function () {
    
    describe('test constructor ', () => {
        it ('test with given name', () => {
            const givenName = 'Pesho';
            const Resort = new SkiResort(givenName);
            expect(Resort.name).to.be.equal(givenName);
        });
    });

    describe('test bestHotel function', () => {
        it ('test No votes yet', () => {
            const skiResort = new SkiResort('Pesho');
            expect(skiResort.bestHotel).to.be.equal('No votes yet');
        });

        it ('test hotel has votes', () => {
            const skiResort = new SkiResort('Pesho');
            skiResort.voters += 3;
            skiResort.build('Sun', 10);
            skiResort.build('Avenue', 15);
            const currentHotel = skiResort.hotels.filter(x =>  x.name == 'Avenue')[0];
            currentHotel.points += 3;
            expect(skiResort.bestHotel).to.be.equal(`Best hotel is Avenue with grade 3. Available beds: 15`);
        })
    });

    describe('test build function', () => {
        it ('test with empty string', () => {
            const skiResort = new SkiResort('Some');
            const result = () =>{
                skiResort.build('', 10);
            };
            expect(result).to.throw('Invalid input');
        });
        
        it ('test successfully building', () => {
            const skiResort = new SkiResort('Some');
            const result = skiResort.build('Some', 30);
            expect(result).to.be.equal(`Successfully built new hotel - Some`);
        });
    });

    describe('test book function', () => {
        it ('test not found hotel with given name', () => {
            const skiResort = new SkiResort('Some');
            const result = () => {skiResort.book('the-best', 10);}
            expect(result).to.throw('There is no such hotel');
        });

        it ('test no free space', () => {
            const skiResort = new SkiResort('Some');
            skiResort.build('the-best', 10);
            const result = () => {skiResort.book('the-best', 20);};
            expect(result).to.throw('There is no free space');
        });
        
        it ('test Successfully booked', () => {
            const skiResort = new SkiResort('Some');
            skiResort.build('the-best', 10);
            const result = skiResort.book('the-best', 5);
            expect(result).to.be.equal('Successfully booked');
        });
    });

    describe('test leave function', () => {
        it ('test no such hotel', ()=> {
            const skiResort = new SkiResort('Some');
            const result = () => {skiResort.leave('the-best', 10, 30);};
            expect(result).to.throw('There is no such hotel');
        });

        it ('test leave left people', ()=> {
            const skiResort = new SkiResort('Some');
            skiResort.build('the-best', 30);
            const result = skiResort.leave('the-best', 40, 10);
            expect(result).to.be.equal('40 people left the-best hotel')
        });
    });

    describe('test averageGrade function', () => {
        it ('test no votes yet', () => {
            const skiResort = new SkiResort('Some');
            expect(skiResort.averageGrade()).to.be.equal('No votes yet');
        });

        it ('test averageGrade successfully', ()=>{
            const skiResort = new SkiResort('Some');
            skiResort.build('the-best', 30);
            skiResort.build('five stars', 50);
            skiResort.voters += 10;
            skiResort.leave('five stars', 5, 10);

            const avg = skiResort.averageGrade();
            expect(avg).to.be.equal('Average grade: 3.33');
        });
    });
});