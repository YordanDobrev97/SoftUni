const food = (function () {
    let products = {
        apple: {
            carbohydrate: 1,
            flavour: 2
        },
        lemonade: {
            carbohydrate: 10,
            flavour: 20
        },
        burger: {
            carbohydrate: 5,
            fat: 7,
            flavour: 3
        },
        eggs: {
            protein: 5,
            fat: 1,
            flavour: 1
        },
        turkey: {
            protein: 10,
            carbohydrate: 10,
            fat: 10,
            flavour: 10
        }
    }

    const ingredients = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    const robot = {
        restock: (microElement, quantity) => {
           if (!ingredients[microElement]){
                ingredients[microElement] = 0;
           }
            ingredients[microElement] += quantity;
            return 'Success';
        },
        prepare: (recipe, quantity) => {
            let result = 'Success';
            const currentIngredients = Object.keys(products[recipe]);
            for(let microElement of currentIngredients) {
                let needed = products[recipe][microElement] * quantity;

                if (ingredients[microElement] < needed) {
                    result = `Error: not enough ${microElement} in stock`;
                    break;
                }
            }

            if (result === 'Success') {
                for(let microElement of currentIngredients) {
                    let needed = products[recipe][microElement] * quantity;
                    ingredients[microElement] -= needed;
                }
            }

            return result;
        },
        report: () => {
            let result = Object.entries(ingredients).map((key) => {
                return `${key[0]}=${key[1]}`;
            });
            return result.join(' ');
        }
    }

    return function (input) {
        const [command, type, quantity] = input.split(' ');

        let result;
        if (command === 'restock'){
            const microElement = type;
            result = robot.restock(microElement, Number(quantity));
        } else if (command === 'prepare'){
            const recipe = type;
            result = robot.prepare(recipe, Number(quantity));
        } else if (command === 'report') {
            result = robot.report();
        }

        return result;
    } 
});

let manager = food();
console.log(manager('restock carbohydrate 10'));
console.log(manager('restock flavour 10'));
console.log(manager('prepare apple 1'));
console.log(manager('restock fat 10'));
console.log(manager('prepare burger 1'));
console.log(manager('report'));



