class ChristmasDinner {
    constructor(budget) {
        this.setBudget(budget);
        this.dishes = [];
        this.products =[];
        this.guests = {};
    }

    setBudget(budget) {
        if (budget < 0) {
            throw Error('The budget cannot be a negative number');
        }
        this.budget = budget;
    }

    shopping([...product]) {
        const nameProduct = product[0];
        const priceProduct =product[1];

        if (priceProduct > this.budget) {
            throw new Error('Not enough money to buy this product');
        }

        this.products.push(nameProduct);
        this.budget -= priceProduct;
        return `You have successfully bought ${nameProduct}!`;
    }

    recipes(recipe) {
        const productName = recipe.recipeName;
        const products =recipe.productsList;
        let isFail = false;
        products.forEach(product => {
            if (!this.products.includes(product)) {
                isFail = true;
            }
        });

        if (isFail) {
            throw new Error('We do not have this product');
        }

        this.dishes.push(recipe);
        return `${productName} has been successfully cooked!`;
    }

    inviteGuests(name, dish) {
        let contains = false;
        this.dishes.forEach(el => {
            if (el.recipeName === dish) {
                contains = true;
            }
        })

        if (!contains) {
            throw new Error('We do not have this dish');
        }

        const keys = Object.keys(this.guests);
        if (keys.includes(name)) {
            throw new Error('This guest has already been invited');
        }
        
        this.guests[name] = dish;
        return `You have successfully invited ${name}!`;
    }

    showAttendance() {
        let result = '';
        for(let guest of Object.keys(this.guests)) {
            const dish =this.guests[guest];
            const listOfProducts = [];
            for(let item of Object.keys(this.dishes)) {
                if (this.dishes[item].recipeName === dish) {
                    listOfProducts.push(this.dishes[item].productsList);
                    break;
                }
            }
            result += `${guest} will eat ${dish}, which consists of ${listOfProducts.join(', ')}\n`;
        }
        return result;
    }
}

let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());