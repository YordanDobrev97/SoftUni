const expect = require('chai').expect;
const lookupChar = require('../03.CharLookup/03.charLookup');

describe('tests', () => {
    it ('test with string and string as index - return undefined', () => {
        expect(lookupChar('Gosho', '13')).to.be.equal(undefined);
    });

    it ('test with invalid type string - return undefined', () => {
        expect(lookupChar(123, 0)).to.be.equal(undefined);
    });

    it ('test with invalid length - return Incorrect index', () => {
        expect(lookupChar('Pesho', 10)).to.be.equal('Incorrect index');
    });

    it ('test with negative index - return Incorrect index', () => {
        expect(lookupChar('Pesho', -10)).to.be.equal('Incorrect index');
    });

    it ('test with correctly data - return 0 index', () => {
        expect(lookupChar('Pesho', 0)).to.be.equal('P');
    });

    it ('test with correctly data - return 4 index', () => {
        expect(lookupChar('Pesho', 4)).to.be.equal('o');
    });

    it ('test with double value for index', () => {
        expect(lookupChar('Ivo', 2.5)).to.be.equal(undefined);
    })
})