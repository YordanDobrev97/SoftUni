function solve(input) {
     const object = {};

     for(let item of input) {   
        const parts = item.split(' : ');
        const key = parts[0];
        const value = Number(parts[1]);

        if (!object.hasOwnProperty(key)) {
            object[key] = 0;
        }
        object[key] = value;
     }

     const sorted = {};
     Object.keys(object).sort().forEach((key) => {
         sorted[key] = object[key];
     });

     const keys = [];
     for(let item in sorted) {
         let firstLetter = item[0];
         if (!keys.includes(firstLetter)) {
            keys.push(firstLetter);
            console.log(firstLetter);
         }

         console.log(`  ${item}: ${sorted[item]}`);
     }
    
}
solve(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
);