let expect = require('chai').expect;

function createCalculator() {
    let value = 0;
    return {
      add: function(num) { value += Number(num); },
      subtract: function(num) { value -= Number(num); },
      get: function() { return value; }
    }
}  

describe('result calculator', function(){
    it('Should return 5', function () {
        let testObj = createCalculator();
        testObj.add(5);
        expect(testObj.get()).to.be.equal(5);
    });
    it('Should return 2 + 3 = 5', function () {
        let testObj = createCalculator();
        testObj.add(2);
        testObj.add(3);
        expect(testObj.get()).to.be.equal(5);
    });
    it('Should return -5', function () {
        let testObj = createCalculator();
        testObj.subtract(3);
        testObj.subtract(2);
        expect(testObj.get()).to.be.equal(-5);
    });
    it('Should return 4.199999999999999', function () {
        let testObj = createCalculator();
        testObj.add(5.3);
        testObj.subtract(1.1);
        expect(testObj.get()).to.be.equal(4.199999999999999);
    });
    it('Should return 2', function () {
        let testObj = createCalculator();
        testObj.add(10);
        testObj.subtract('7');
        testObj.add('-2');
        testObj.subtract(-1);
        expect(testObj.get()).to.be.equal(2);
    });
    it('Should return NaN', function () {
        let testObj = createCalculator();
        testObj.add('hello');
        expect(testObj.get()).to.be.NaN;
    });
    
})
