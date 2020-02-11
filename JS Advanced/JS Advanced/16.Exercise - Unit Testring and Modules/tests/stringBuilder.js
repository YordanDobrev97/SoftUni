const expect = require('chai').expect;
const StringBuilder = require('../05.StringBuilder/string-builder.js');

describe('test string-builder class', () => {
    let sb;

    beforeEach(() => {
        sb = new StringBuilder();
    });

    it ('test constructor without parameter initialization', () => {
        expect(sb.stringArray).to.include([]);
    });

    it ('test constructor with correctly parameter initialization', () => {
        sb = new StringBuilder('hello');
        expect(sb._stringArray.length).to.be.equal(5);
    });

    it ('test constructor with incorrectly parameter initialization', () => {
        expect(() => new StringBuilder([])).to.throw('Argument must be string');
    });

    it ('test append function with string', () => {
        sb.append('Pesho');
        expect(sb.toString()).to.be.equal('Pesho');
    });

    it ('test append function with array - throw exception', () => {
        expect(() => new StringBuilder().append([])).to.throw('Argument must be string');
    });

    it ('test append function - increasing length', () => {
        sb = new StringBuilder('Pesho');
        sb.append('Pepi');
        expect(sb._stringArray.length).to.be.equal(9);
    })

    it ('test prepend function', () => {
        sb.prepend('Gosho');
        expect(sb.toString()).to.be.equal('Gosho');
    });

    it ('test prepend function with number value - throw exception', () => {
        expect(() => new StringBuilder().prepend(1)).to.throw('Argument must be string');
    });

    it ('test insertAt function', () => {
        sb.append('Gosho');
        sb.insertAt('Pesho', 0);
        expect(sb.toString()).to.be.equal('PeshoGosho');
    });

    it ('test insertAt function with boolean value', () => {
        expect(() => new StringBuilder().insertAt(true)).to.throw('Argument must be string');
    });

    it ('test remove function', () => {
        sb.append('Pesho');
        sb.remove(0, 5);
        expect(sb.toString()).to.be.equal('');
    });
})
