let expect = require('chai').expect;

function sumArray(array){
    let sum = 0;
    for(let item of array)
    {
        sum +=item;
    }
    return sum;
}

describe('TestArray()', function(){
    it('should be [1,2] equal 3', function(){
        expect(sumArray([1,2])).to.be.equal(3);
    });
    it('should be []', function(){
        expect(sumArray([])).to.be.equal(0);
    })
})