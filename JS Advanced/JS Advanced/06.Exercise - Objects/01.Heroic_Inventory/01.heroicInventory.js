function solve(input) {
    let result = [];

    for (let key of input) {
        let items = key.split(" / ");
        let heroName = items[0];
        let heroLevel = Number(items[1]);
        let itemsHero = [];
        if (items.length === 3) {
            itemsHero = items[2].split(", ");
        }
        
        let resultObj = {
            name: heroName,
            level: heroLevel,
            items: itemsHero
        };

        result.push(resultObj);
    }

    let output = JSON.stringify(result);
    console.log(output);
}
solve(['Jake / 1000']);
