let expect = require('chai').expect;
class SubscriptionCard {
    constructor(firstName, lastName, SSN) {
      this._firstName = firstName;
      this._lastName = lastName;
      this._SSN = SSN;
      this._subscriptions = [];
      this._blocked = false;
    }
    get firstName() {
      return this._firstName;
    }
  
    get lastName() {
      return this._lastName;
    }
    get SSN() {
      return this._SSN;
    }
  
    get isBlocked() {
      return this._blocked;
    }

    addSubscription(line, startDate, endDate) {
      this._subscriptions.push({
        line,
        startDate,
        endDate
      });
    }
    isValid(line, date) {
      if (this.isBlocked) return false;
      return this._subscriptions.filter(s => s.line === line || s.line === '*')
        .filter(s => {
          return s.startDate <= date &&
            s.endDate >= date;
        }).length > 0;
    }
  
    block() {
      this._blocked = true;
    }
  
    unblock() {
      this._blocked = false;
    }
}
describe('SubscriptionCard tests', function () {
    describe('test for constructor', function(){
        it('is intilizate correctly constructor ', function(){
            let card = new SubscriptionCard('Pesho','Peshov','0xx0x0xx0x')
            expect(card.firstName).to.be.equal('Pesho');
            expect(card.lastName).to.be.equal('Peshov');
            expect(card.SSN).to.be.equal('0xx0x0xx0x');
        });
        it('is not intilizate correctly constructor ', function(){
            let card = new SubscriptionCard('Pesho')
            expect(card.firstName).to.be.equal('Pesho');
            expect(card.lastName).to.be.undefined;
            expect(card.SSN).to.be.undefined;
        });
    }) ;
    describe('test for accessor', function(){
        it('is set block card of true', function(){
            let card = new SubscriptionCard('Pesho', 'Peshov', '9d9d999999s2');
            card.block();
            expect(card._blocked).to.equal(true);
        });
        it('is unset block card of false (return true)', function(){
            let card = new SubscriptionCard('Pesho', 'Peshov', '9d9d999999s2');
            card.block();
            card.unblock();
            expect(card._blocked).to.equal(false);
        });
    });
    describe('AddSubscription card is correctly', function(){
      it('add subscription correctly', function(){
        const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
        card.addSubscription('120', new Date('2018-04-22'), 
        new Date('2018-05-21'));
        expect(card._subscriptions.length).to.equal(1);
      }
    )
    });
    describe('Is Valid SubscriptionCard tests', function(){
      it('valid line and Date SubscriptionCard', function(){
        const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
        card.addSubscription('120', new Date('2018-04-22'), 
        new Date('2018-05-21'));
        expect(card.isValid('120', new Date('2018-04-22'))).to.equal(true);
      });
      it('not valid line and Date SubscriptionCard', function(){
        const card = new SubscriptionCard('Pesho', 'Petrov', '00000000');
        card.addSubscription('120', new Date('2018-04-22'), 
         new Date('2018-05-21'));
         expect(card.isValid('12', new Date('2018-04-23'))).to.equal(false);
         card.block();
         expect(card.isValid('120', new Date('2018-04-22'))).to.equal(false);
         card.unblock();
         expect(card.isValid('120', new Date('2018-04-22'))).to.equal(true);
      });
    });
});
