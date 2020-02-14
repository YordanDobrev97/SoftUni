const expect = require('chai').expect;
const Warehouse = require('../07.Warehouse/warehouse');

describe('test class Warehouse', () => {
  let warehouseObj;

  beforeEach(() => {
    warehouseObj = new Warehouse(10);
  });

  it('test constructor set capacity', () => {
    expect(warehouseObj.capacity).to.be.equal(10);
  });

  it('test constructor set 0 capacity', () => {
    const result = () => {
      warehouseObj = new Warehouse(0);
    };
    expect(result).to.throw('Invalid given warehouse space');
  });

  it('test constructor set capacity invalid data', () => {
    const result = () => {
      warehouseObj = new Warehouse('string');
    };
    expect(result).to.throw('Invalid given warehouse space');
  });

  it('test occupiedCapacity function with empty capacity', () => {
    const occupiedCapacity = warehouseObj.occupiedCapacity();
    expect(occupiedCapacity).to.be.equal(0);
  });

  it('test occupiedCapacity with added product', () => {
    warehouseObj.addProduct('Food', 'Chocolate', 1);
    const occupiedCapacity = warehouseObj.occupiedCapacity();
    expect(occupiedCapacity).to.be.equal(1);
  });

  it('test addProduct function with valid data', () => {
    const productObj = warehouseObj.addProduct('Drink', 'Beer', 2);
    expect(productObj).has.ownProperty('Beer');
    expect(productObj['Beer']).to.be.equal(2);
  });

  it('test addProduct function with invalid data', () => {
    const productObj = () => {
      warehouseObj.addProduct('Food', 'Bread', 100);
    };
    expect(productObj).to.throw(
      'There is not enough space or the warehouse is already full'
    );
  });

  it ('test orderProducts function', () => {
      warehouseObj.addProduct('product', 'A', 1);
      warehouseObj.addProduct('product2', 'B', 1);

      warehouseObj.orderProducts('product');
      console.log(warehouseObj);
  });
});
