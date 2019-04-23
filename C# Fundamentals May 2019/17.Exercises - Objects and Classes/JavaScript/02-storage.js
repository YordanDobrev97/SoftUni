class Storage {
    constructor(capacity) {
       this.capacity = capacity;
       this.products = [];
       this.totalCost = 0;
    }

    addProduct(newProduct) {
        let getQuantity = newProduct['quantity'];
        this.capacity -= getQuantity;
        this.products.push(newProduct);
        this.sumCost();
    }
    getProducts(){
        for(let product of this.products) {
            console.log(JSON.stringify(product));
        }
    }
    sumCost(){
        let sumCost = 0;

        for(let product of this.products) {
            let price = product['price'];
            let quantity = product['quantity'];
            let result = price * quantity;
            sumCost += result;
        }
        this.totalCost = sumCost;
    }
}

let productOne = {name: 'Cucamber', price: 1.50, quantity: 15}
let productTwo = {name: 'Tomato', price: 0.90, quantity: 25}
let productThree = {name: 'Bread', price: 1.10, quantity: 8}
let storage = new Storage(50)
storage.addProduct(productOne)
storage.addProduct(productTwo)
storage.addProduct(productThree)
storage.getProducts()
console.log(storage.capacity)
console.log(storage.totalCost)
