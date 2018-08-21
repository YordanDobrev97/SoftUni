let expect = require('chai').expect;
function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }
    return "odd";
}
describe('string length is even or odd ', function(){
    it('Should return odd', function () {
        let string = isOddOrEven('pesho');
        expect(string).to.be.equal('odd');
    });
    it('Should return even', function () {
        let string = isOddOrEven('pe');
        expect(string).to.be.equal('even');
    });
    it('Should return odd', function () {
        let string = isOddOrEven('pes');
        expect(string).to.be.equal('odd');
    });
    it('Should return even', function () {
        let string = isOddOrEven('gosh');
        expect(string).to.be.equal('even');
    });
    it('Should return undefined', function () {
        let string = isOddOrEven(1);
        expect(string).to.be.equal(undefined,'Function did not return the correct result!');
    });
    it('Should return undefined', function () {
        let string = isOddOrEven({});
        expect(string).to.be.equal(undefined, 'Function did not return the correct result!');
    });
})
