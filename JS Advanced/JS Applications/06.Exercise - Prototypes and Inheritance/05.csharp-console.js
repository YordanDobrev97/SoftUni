class Console {

    static get placeholder() {
      return /{\d+}/g;
    }
  
    static writeLine() {
      let message = arguments[0];
      if (arguments.length === 1) {
        if (typeof (message) === 'object') {
          message = JSON.stringify(message);
          return message;
        }
        else if (typeof(message) === 'string') {
          return message;
        }
      }
      else {
        if (typeof (message) !== 'string') {
          throw new TypeError("No string format given!");
        }
        else {
          let tokens = message.match(this.placeholder).sort(function (a, b) {
            a = Number(a.substring(1, a.length - 1));
            b = Number(b.substring(1, b.length - 1));
            return a - b;
          });
          if (tokens.length !== (arguments.length - 1)) {
            throw new RangeError("Incorrect amount of parameters given!");
          }
          else {
            for (let i = 0; i < tokens.length; i++) {
              let number = Number(tokens[i].substring(1, tokens[i].length - 1));
              if (number !== i) {
                throw new RangeError("Incorrect placeholders given!");
              }
              else {
                message = message.replace(tokens[i], arguments[i + 1])
              }
            }
            return message;
          }
        }
      }
    }
};


const expect = require('chai').expect;

describe('test console class', function(){
    it ('test writeline sample string', function(){
        const result = Console.writeLine('write text');
        expect(result).to.be.equal('write text');
    });

    it ('test object parameter', function(){
        const result = Console.writeLine({name: 'Jonh'});
        expect(result).to.be.equal(JSON.stringify({name: 'Jonh'}));
    });

    it ('test valid placeholders', function(){
       const result = Console.writeLine("My name is {0} {1}.", 'Gosho', 'G');
       expect(result).to.be.equal('My name is Gosho G.');
    });

    it ('test invalid first parameter placeholder', function(){
        const result = () => {Console.writeLine({}, "invalid text");}
        expect(result).to.throw('No string format given!')
    });

    it ('test incorrect amount of parameters given', function(){
        const result = () => {Console.writeLine("My name is {0}", "Gosho", "G");}
        expect(result).to.throw('Incorrect amount of parameters given!')
    });

    it ('test Incorrect placeholders given', function(){
        const result = () => {Console.writeLine("My name is {1}", "Gosho");}
        expect(result).to.throw('Incorrect placeholders given!')
    });
});