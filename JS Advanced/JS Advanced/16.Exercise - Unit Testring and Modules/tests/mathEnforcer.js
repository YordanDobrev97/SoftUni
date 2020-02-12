const expect = require('chai').expect;
const mathEnforcer = require('../04.MathEnforcer/04.mathEnforcer');

describe('test math enforcer', () => {
    describe('test add five function', () => {
        it ('test with correctly data', () => {
           expect(mathEnforcer.addFive(10)).to.be.equal(15);
        });

        it ('test with array data - return undefined result', () => {
            expect(mathEnforcer.addFive([1,2,3])).to.be.equal(undefined);
        });

        it ('test with double value', () => {
            expect(mathEnforcer.addFive(5.5)).to.be.equal(10.5);
        });

        it ('test with negative value', () => {
            expect(mathEnforcer.addFive(-10)).to.be.equal(-5);
        });
    })

    describe('test subtract ten function', () => {
        it ('test subtract with correctly data', () => {
            expect(mathEnforcer.subtractTen(20)).to.be.equal(10);
        });

        it ('test subtract with array data - return undefined', () => {
            expect(mathEnforcer.subtractTen("20")).to.be.equal(undefined);
        });

        it ('test subtract with double value', () => {
            expect(mathEnforcer.subtractTen(5.5)).to.be.equal(-4.5);
        });

        it ('test subtract negative value', () => {
            expect(mathEnforcer.subtractTen(-15)).to.be.equal(-25);
        });

        it("should return correct result for floating point parameter", function () {
            expect(mathEnforcer.addFive(3.14)).to.be.closeTo(8.14, 0.01);
        });
    });

    describe('test sum function', () => {
        it('test with correctly data', () => {
            expect(mathEnforcer.sum(20, 20)).to.equal(40);
        });

        it('test with first param array data - return undefined', () => {
            expect(mathEnforcer.sum([], 20)).to.equal(undefined);
        });

        it('test with first and second param array data - return undefined', () => {
            expect(mathEnforcer.sum([], [])).to.equal(undefined);
        });

        it ('test with double values', () => {
            expect(mathEnforcer.sum(5.5, 10.5)).to.be.equal(16);
        });

        it ('test with negative value', () => {
            expect(mathEnforcer.sum(-4, -2)).to.be.equal(-6);
        });

        it ('test with floating point negative', () => {
            expect(mathEnforcer.sum(-4.2, -1.2)).to.be.equal(-5.4);
        });

        it("should return correct result for floating point parameters", function () {
            expect(mathEnforcer.sum(2.7, 3.4)).to.be.closeTo(6.1, 0.01);
        })
    });
});