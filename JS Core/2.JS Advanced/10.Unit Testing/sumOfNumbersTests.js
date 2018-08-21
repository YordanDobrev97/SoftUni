let expect = require('chai').expect;
function sumArray(arr){
    let sum = 0;
    for (num of arr)
        sum += Number(num);
    return sum;
}
describe('sumArray()', function(){
    it('shoubld be return 3', function(){
        expect(sumArray([1,2])).to.equal(3);
    })
    it('shoubld be return 1', function(){
        expect(sumArray([1])).to.equal(1);
    })
    it('shoubld be return 0', function(){
        expect(sumArray([])).to.be.equal(0);
    })
    it('shoubld be return 3', function(){
        expect(sumArray([1.5, 2.5, -1])).to.be.equal(3);
    })
    it('shoubld be return NaN', function(){
        expect('invalid data').to.be.equal('something other');
    })
})
