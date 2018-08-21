let expect = require('chai').expect;

let mathEnforcer = {
    addFive: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num + 5;
    },
    subtractTen: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function (num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};
describe('MathEnforcer()', function(){
    it('Shoubld be return 5 + 3 = 8', function(){
        let number = 3;
        let result = mathEnforcer.addFive(number);
        expect(result).to.be.equal(8);
    });
    it('Shoubld be return undefined', function(){
        let number = 'Pesho'
        let result = mathEnforcer.addFive(number);
        expect(result).to.be.equal(undefined);
        
    });
    it('Shoubld be return 30 - 10 = 20', function(){
        let number = 30;
        let result = mathEnforcer.subtractTen(number);
        expect(result).to.be.equal(20); 
    });
    it('Shoubld be return undefined', function(){
        let number = 'Pesho';
        let result = mathEnforcer.subtractTen(number);
        expect(result).to.be.equal(undefined);
    });
    it('Shoubld be return undefined', function(){
        let number1 = '5';
        let number2 = 5;
        let result = mathEnforcer.sum(number1, number2);
        expect(result).to.be.equal(undefined);
    });
    it('Shoubld be return 10 + (-5) = 5', function(){
        let number1 = 10;
        let number2 = -5;
        let result = mathEnforcer.sum(number1, number2);
        expect(result).to.be.equal(5);
    });
    it('Shoubld be return 10 - 10 = 0', function(){
        let number1 = 10;
        let result = mathEnforcer.subtractTen(number1);
        expect(result).to.be.equal(0);
    });
    it('Shoubld be return 10.10 + 5 = 15.1', function(){
        let number1 = 10.10;
        let result = mathEnforcer.addFive(number1);
        expect(result).to.be.equal(15.1);
    });
    it('Shoubld be return 10.10 + 5 = 15.1', function(){
        let number1 = 10.10;
        let number2 = 10.10;
        let result = mathEnforcer.sum(number1, number2);
        expect(result).to.be.equal(20.2);
    });
    it('Shoubld be return 10.10 + 5 = 15.1', function(){
        let number1 = 0;
        let number2 = 0;
        let result = mathEnforcer.sum(number1, number2);
        expect(result).to.be.equal(0);
    });
    it('Shoubld be return 0.1 + 0.2 = 0.30000000000000004', function(){
        let number1 = 0.1;
        let number2 = 0.2;
        let result = mathEnforcer.sum(number1, number2);
        expect(result).to.be.equal(0.30000000000000004);
    });
    it('Shoubld be return undefined', function(){
        let number1 = '0.1';
        let number2 = 0.2;
        let result = mathEnforcer.sum(number1, number2);
        expect(result).to.be.equal(undefined);
    });
    it('Shoubld be return 0', function(){
        let number1 = -5;
        let result = mathEnforcer.addFive(number1);
        expect(result).to.be.equal(0);
    });
    it('Shoubld be return -20', function(){
        let number1 = -10;
        let result = mathEnforcer.subtractTen(number1);
        expect(result).to.be.equal(-20);
    });
    it('Shoubld be return undefined', function(){
        let number1 = 'Not a number';
        let number2 = 10;
        let result = mathEnforcer.sum(number1, number2);
        expect(result).to.be.equal(undefined);
    });
    it('Shoubld be return undefined', function(){
        let number1 = 'Not a number';
        let number2 = 10;
        let result = mathEnforcer.subtractTen(number1, number2);
        expect(result).to.be.equal(undefined);
    });
    it('Shoubld be return undefined', function(){
        let number1 = 10;
        let number2 = 'Not a number';
        let result = mathEnforcer.subtractTen(number1, number2);
        expect(result).to.be.equal(undefined);
    });
});