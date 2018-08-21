let expect = require('chai').expect;
function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }
    if (string.length <= index || index < 0) {
        return "Incorrect index";
    }

    return string.charAt(index);
}
describe('Find index at string', function(){
    it('Shoubld be return undefined', function(){
        let string = {};
        let index = '10';
        let result = lookupChar(string, index);
        expect(result).to.be.equal(undefined);
    });
    it('Shoubld be return undefined', function(){
        let string = {};
        let index = 1;
        let result = lookupChar(string, index);
        expect(result).to.be.equal(undefined);
    });
    it('Shoubld be return undefined', function(){
        let string = 'Pesho';
        let index = undefined;
        let result = lookupChar(string, index);
        expect(result).to.be.equal(undefined);
    });
    it('Shoubld be return Incorrect index', function(){
        let string = 'Pesho';
        let index = 100;
        let result = lookupChar(string, index);
        expect(result).to.be.equal('Incorrect index');
    });
    it('Shoubld be return Incorrect index', function(){
        let string = 'Pesho';
        let index = -1;
        let result = lookupChar(string, index);
        expect(result).to.be.equal('Incorrect index');
    });
    it('Shoubld be return index', function(){
        let string = 'Pesho';
        let index = 0;
        let result = lookupChar(string, index);
        expect(result).to.be.equal('P');
    });
    it('Shoubld be return index', function(){
        let string = 'Pesho';
        let index = 4;
        let result = lookupChar(string, index);
        expect(result).to.be.equal('o');
    });
    it('Shoubld be return Incorrect index', function(){
        let string = 'Pesho';
        let index = 5;
        let result = lookupChar(string, index);
        expect(result).to.be.equal('Incorrect index');
    });
    it('Shoubld be return undefined', function(){
        let string = 'Pesho';
        let index = 0.6;
        let result = lookupChar(string, index);
        expect(result).to.be.equal(undefined);
    });
});
