const expect = require('chai').expect;
const mathEnforcer = require('../04.MathEnforcer/04.mathEnforcer');

describe('test math enforcer', () => {
    describe('test add five function', () => {
        it ('test with correctly data', () => {
           expect( mathEnforcer.addFive(10)).to.be.equal(15);
        });

        it ('test with array data - return undefined result', () => {
            expect( mathEnforcer.addFive([1,2,3])).to.be.equal(undefined);
        });
    })

    describe('test subtract ten function', () => {
        it ('test subtract with correctly data', () => {
            expect(mathEnforcer.subtractTen(20)).to.be.equal(10);
        })

        it ('test subtract with array data - return undefined', () => {
            expect(mathEnforcer.subtractTen("20")).to.be.equal(undefined);
        })
    });

    describe('test sum function', () => {
        it('test with correctly data', () => {
            expect(mathEnforcer.sum(20, 20)).to.equal(40);
        });

        it('test with first param array data - return undefined', () => {
            expect(mathEnforcer.sum([], 20)).to.equal(undefined);
        })

        it('test with second param array data - return undefined', () => {
            expect(mathEnforcer.sum(20, [])).to.equal(undefined);
        })

        it('test with first and second param array data - return undefined', () => {
            expect(mathEnforcer.sum([], [])).to.equal(undefined);
        })
    });
});