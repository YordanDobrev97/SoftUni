function solve(input) {
    let obj = {};

    for(let item of input) {
        const element = item.split(' | ');
        const town = element[0];
        const product = element[1];
        const price = Number(element[2]);

        if (!obj.hasOwnProperty(product)) {
            obj[product] = {};
        }

        if (!obj[product].hasOwnProperty(town)) {
            obj[product][town] = 0;
        }
        obj[product][town] = price;
    }

    obj = filterObjMin(obj);

    for(let product of Object.keys(obj)) {
        const key = obj[product];
        let town = Object.keys(key);
        let price = obj[product][town];
        console.log(`${product} -> ${price} (${town})`);
    }

    function filterObjMin(object) {
        const keys = Object.keys(object);

        let min = Number.MAX_SAFE_INTEGER;
        let minProperty = undefined;
        let resultObj = {};

        for(let key in keys) {
            const keyProperty = keys[key];
            for(let value in object[keyProperty]) {
                if (min > object[keyProperty][value]) {
                    min = object[keyProperty][value];
                    resultObj[keyProperty] = {};
                    resultObj[keyProperty][value] = min;
                }
            }
            min = Number.MAX_SAFE_INTEGER;
        }

        return resultObj;
    }
}

solve([
  "Sample Town | Sample Product | 1000",
  "Sample Town | Orange | 2",
  "Sample Town | Peach | 1",
  "Sofia | Orange | 3",
  "Sofia | Peach | 2",
  "New York | Sample Product | 1000.1",
  "New York | Burger | 10"
]);
