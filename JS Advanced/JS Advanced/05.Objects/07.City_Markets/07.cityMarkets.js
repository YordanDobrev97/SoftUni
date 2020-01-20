function solve(input) {

    let obj = {};
    for(let item of input) {
        const elements = item.split(' -> ');
        const town = elements[0];
        const product = elements[1];
        const valuesNums = elements[2].split(' : ');
        const amountOfSales = Number(valuesNums[0]);
        const priceForOneUnit = Number(valuesNums[1]);
        const income = amountOfSales * priceForOneUnit;

        if (!obj.hasOwnProperty(town)) {
            obj[town] = {};
        }

        if (!obj[town].hasOwnProperty(product)) {
            obj[town][product] = 0;
        }
        obj[town][product] += income;
    }

    for (const key in obj) {
        console.log(`Town - ${key}`);
        let value = obj[key];
        for (const valueKey in value) {
            console.log(`$$$${valueKey} : ${value[valueKey]}`);
        }
    }
}

solve([
  "Sofia -> Laptops HP -> 200 : 2000",
  "Sofia -> Raspberry -> 200000 : 1500",
  "Sofia -> Audi Q7 -> 200 : 100000",
  "Montana -> Portokals -> 200000 : 1",
  "Montana -> Qgodas -> 20000 : 0.2",
  "Montana -> Chereshas -> 1000 : 0.3"
]);
