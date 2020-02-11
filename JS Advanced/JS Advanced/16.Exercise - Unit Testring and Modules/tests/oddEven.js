const expect = require('chai').expect;
const isOddOrEven = require('../02.OddOrEven/02.oddOrEven');

describe('test even odd function', () => {
    it ('test with number param return undefined', () => {
        expect(isOddOrEven(123)).to.be.equal(undefined);
    })

    it ('test with object param return undefined', () => {
        expect(isOddOrEven({'a': 1})).to.be.equal(undefined);
    })

    it ('test with even length', () => {
        expect(isOddOrEven('1234')).to.be.equal('even');
    })

    it ('test with odd length', () => {
        expect(isOddOrEven('123')).to.be.equal('odd');
    })

    it ('test with odd length return wrong result', () => {
        expect(isOddOrEven('1')).to.not.equal('even');
    })
})