let expect = require('chai').expect;

function isSymmetric(arr) {
    if (!Array.isArray(arr))
      return false; 
    let reversed = arr.slice(0).reverse(); 
    let equal = 
      (JSON.stringify(arr) == JSON.stringify(reversed));
    return equal;
  }
  

describe('Symmetric', function(){
    it('shoubld be return true', function(){
        let isSymmetricResult = isSymmetric([1,2,3,3,2,1]);
        expect(isSymmetricResult).to.be.equal(true);
    })
    it('shoubld be return true', function(){
        let isSymmetricResult = isSymmetric([-1,2,-1]);
        expect(isSymmetricResult).to.be.equal(true);
    })
    it('shoubld be return false', function(){
        let isSymmetricResult = isSymmetric([1,2]);
        expect(isSymmetricResult).to.be.equal(false);
    })
    it('shoubld be return true', function(){
        let isSymmetricResult = isSymmetric([5,'hi',{a:5},new Date(),{a:5},'hi',5]);
        expect(isSymmetricResult).to.be.equal(true);
    })
    it('shoubld be return false', function(){
        let isSymmetricResult = isSymmetric([5,'hi',{a:5},new Date(),{X:5},'hi',5]);
        expect(isSymmetricResult).to.be.equal(false);
    })
    it('shoubld be return false', function(){
        let isSymmetricResult = isSymmetric([1,2,3,4,2,1]);
        expect(isSymmetricResult).to.be.equal(false);
    })
    it('shoubld be return false', function(){
        let isSymmetricResult = isSymmetric([-1,2,1]);
        expect(isSymmetricResult).to.be.equal(false);
    })
    it('shoubld be return true', function(){
        let isSymmetricResult = isSymmetric([1]);
        expect(isSymmetricResult).to.be.equal(true);
    })
    
})
