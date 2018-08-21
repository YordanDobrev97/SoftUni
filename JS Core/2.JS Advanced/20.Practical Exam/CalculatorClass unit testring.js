let expect = require('chai').expect;

class Calculator {
  constructor() {
      this.expenses = [];
  }

  add(data) {
      this.expenses.push(data);
  }
  divideNums() {
      let divide;
      for (let i = 0; i < this.expenses.length; i++) {
          if (typeof (this.expenses[i]) === 'number') {
              if (i === 0 || divide===undefined) {
                  divide = this.expenses[i];
              } else {
                  if (this.expenses[i] === 0) {
                      return 'Cannot divide by zero';
                  }
                  divide /= this.expenses[i];
              }
          }
      }
      if (divide !== undefined) {
          this.expenses = [divide];
          return divide;
      } else {
         throw new Error('There are no numbers in the array!')
      }
  }
  toString() {
      if (this.expenses.length > 0)
          return this.expenses.join(" -> ");
      else return 'empty array';
  }

  orderBy() {
      if (this.expenses.length > 0) {
          let isNumber = true;
          for (let data of this.expenses) {
              if (typeof data !== 'number')
                  isNumber = false;
          }
          if (isNumber) {
              return this.expenses.sort((a, b) => a - b).join(', ');
          }
          else {
              return this.expenses.sort().join(', ');
          }
      }
      else return 'empty';
  }
}
describe('Unit testring', function () {
    describe('Test intilizate array ', function(){
        it('array its 0 items', function(){
            let calc = new Calculator();
            expect(calc.expenses.length).to.be.equal(0);
        });
    });
    describe('add item in array ', function(){
      it('add integers in array', function(){
          let calc = new Calculator();
          calc.add(1);
          calc.add(2);
          expect(calc.toString()).to.be.equal("1 -> 2");
      });
      it('add real numbers in array', function(){
        let calc = new Calculator();
        calc.add(1.2);
        calc.add(2.50);
        expect(calc.toString()).to.be.equal("1.2 -> 2.5");
    });
      it('add array[] in array', function(){
       let calc = new Calculator();
       calc.add([1,2,3]);
       calc.add([4,8,0]);
       expect(calc.toString()).to.be.equal("1,2,3 -> 4,8,0");
    });
      it('add object in array', function(){
        let calc = new Calculator();
        calc.add({});
        expect(calc.toString()).to.be.equal("[object Object]");
    });
    });
    describe('toString items', function(){
      it('return empty array ', function(){
        let calc = new Calculator();
        expect(calc.toString()).to.be.equal('empty array');
    });
    });
    describe('divide numbers', function(){
        it('divide 2 and 5 correctly', function(){
            let calc = new Calculator();
            calc.add(5);
            calc.add(2);
            expect(calc.divideNums()).to.be.equal(2.5);
        });
    });
    describe('Order numbers', function(){
        it('Return empty', function(){
            let calc = new Calculator();
            expect(calc.orderBy()).to.be.equal('empty');
        });
        it('order numbers', function(){
            let calc = new Calculator();
            calc.add(5);
            calc.add(2);
            calc.add(0);
            calc.add(9);
            expect(calc.orderBy()).to.be.equal('0, 2, 5, 9');
        });
        it('order mix', function(){
            let calc = new Calculator();
            calc.add(5);
            calc.add('pesho');
            calc.add(2.222);
            calc.add(9);
            expect(calc.orderBy()).to.be.equal('2.222, 5, 9, pesho');
        });
    });
});
