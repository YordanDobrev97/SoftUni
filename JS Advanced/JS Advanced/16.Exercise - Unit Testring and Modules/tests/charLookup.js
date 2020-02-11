const expect = require('chai').expect;
const lookupChar = require('../03.CharLookup/03.charLookup');

describe('tests', () => {
    it ('test with empty string - return Incorrect', () => {
        expect(lookupChar('', 13)).to.be.equal('Incorrect index');
    })

    it ('test with string and string as index - return Incorrect', () => {
        expect(lookupChar('Gosho', '13')).to.be.equal(undefined);
    })

    it ('test with invalid type string - return undefined', () => {
        expect(lookupChar(123, 0)).to.be.equal(undefined);
    })

    it ('test with invalid index - return undefined', () => {
        expect(lookupChar('Pesho', {})).to.be.equal(undefined);
    })

    it ('test with invalid type string and index - return undefined', () => {
        expect(lookupChar([], {})).to.be.equal(undefined);
    })

    it ('test with invalid length - return Incorrect index', () => {
        expect(lookupChar('Pesho', 10)).to.be.equal('Incorrect index');
    })

    it ('test with equal length and index - return Incorrect index', () => {
        expect(lookupChar('Pesho', 5)).to.be.equal('Incorrect index');
    })

    it ('test with negative index - return Incorrect index', () => {
        expect(lookupChar('Pesho', -10)).to.be.equal('Incorrect index');
    })

    it ('test with correctly data - return 0 index', () => {
        expect(lookupChar('Pesho', 0)).to.be.equal('P');
    })

    it ('test with correctly data - return 4 index', () => {
        expect(lookupChar('Pesho', 4)).to.be.equal('o');
    })
})