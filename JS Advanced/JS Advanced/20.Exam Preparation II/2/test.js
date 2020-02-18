const expect  = require('chai').expect;
const PizzUni = require('./02.pizzUni');

describe('test PizzUni class', () => {
    it ('test constructor', () => {
        const pizzUni = new PizzUni();
        expect(pizzUni.registeredUsers.length).to.be.equal(0);
    });

    it ('test registerUser function with contains user', () => {
        const pizzUni = new PizzUni();
        pizzUni.registerUser('pesho@petrov');
        const result = ()=> {pizzUni.registerUser('pesho@petrov')};
        expect(result).to.throw(`This email address (pesho@petrov) is already being used!`)
    });

    it ('test makeAnOrder() function make order without registration', () => {
        const pizzUni = new PizzUni();
        const result = () => {pizzUni.makeAnOrder('pencho@penchov')};
        expect(result).to.throw(`You must be registered to make orders!`);
    });

    it ('test makeAnOrder() function make order with registration', () => {
        const pizzUni = new PizzUni();
        pizzUni.registerUser('baiIvan@gmail.com');
        const result = pizzUni.makeAnOrder('baiIvan@gmail.com', 'Barbeque Classic', 'Coca-Cola');
        expect(result).to.be.equal(0);
    });

    it ('test makeAnOrder() function make order not availableProducts', () => {
        const pizzUni = new PizzUni();
        pizzUni.registerUser('baiIvan@gmail.com');
        const result = () => {pizzUni.makeAnOrder('baiIvan@gmail.com', 'classic', 'cola')};
        expect(result).to.throw('You must order at least 1 Pizza to finish the order.');
    });

    it ('test detailsAboutMyOrder() function return status order', () => {
        const pizzUni = new PizzUni();
        pizzUni.registerUser('baiIvan@gmail.com');
        pizzUni.makeAnOrder('baiIvan@gmail.com', 'Barbeque Classic', 'Coca-Cola');
        const detailsOrder = pizzUni.detailsAboutMyOrder(0);
        expect(detailsOrder).to.be.equal(`Status of your order: pending`);
    });

    it ('test completeOrder() function successfully', () => {
        const pizzUni = new PizzUni();
        pizzUni.registerUser('baiIvan@gmail.com');
        pizzUni.makeAnOrder('baiIvan@gmail.com', 'Barbeque Classic', 'Coca-Cola');
        const order = pizzUni.completeOrder();
        expect(order.status).to.be.equal('completed');
    });
});