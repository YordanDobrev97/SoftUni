function solve(input) {
    const object = {};

    for(let item of input) {
        const parts = item.split(' | ');
        const brand = parts[0];
        const model = parts[1];
        let producedCar = Number(parts[2]);

        if (!object.hasOwnProperty(brand)) {
            object[brand] = {};
        }
        if (!object[brand].hasOwnProperty(model)) {
            object[brand][model] = 0;
        }
        object[brand][model] += producedCar;
    }

    for(let brand in object) {
        console.log(brand);
        const model = Object.keys(object[brand]);
        for(let item in model) {
            console.log(`###${model[item]} -> ${object[brand][model[item]]}`);
        }
    }
}
solve(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']
);