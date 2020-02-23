const expect = require('chai').expect;
const Parser = require('./solution');
describe('test', () => {
    it ('test constructor', () => {
        const myClass = new Parser('[ {"Nancy":"architect"},{"John":"developer"},{"Kate": "HR"} ]');
        const result = myClass._log;
        expect(result).to.deep.equal([]);   
    });

    it ('test addEntries() function', ()=>{
        const myClass = new Parser('[ {"Nancy":"architect"},{"John":"developer"},{"Kate": "HR"} ]');
        const result = myClass.addEntries("Steven:tech-support Edd:administrator");
        expect(result).to.be.equal('Entries added!');
    });

    it ('test removeEntry() function not exist', ()=>{
        const myClass = new Parser('[ {"Nancy":"architect"},{"John":"developer"},{"Kate": "HR"} ]');
        const result = () =>{myClass.removeEntry('Pesho')};
        expect(result).to.throw('There is no such entry!');
    });

    it ('test removeEntry() function with exist entry', ()=>{
        const myClass = new Parser('[ {"Nancy":"architect"},{"John":"developer"},{"Kate": "HR"} ]');
        myClass.addEntries('Steven:tech-support Edd:administrator');
        myClass.removeEntry('Steven');
        expect(myClass._data[3].deleted).to.be.equal(true);
    });

    it ('test print()', ()=> {
        const myClass = new Parser('[ {"Nancy":"architect"} ]');
        const print = myClass.print();
        expect(print).to.be.equal('id|name|position\n0|Nancy|architect');
    });
});