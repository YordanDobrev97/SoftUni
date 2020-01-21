function solve(input) {
    let result = [];

    for (let key of input) {
        let items = key.split(" / ");
        let heroName = items[0];
        let heroLevel = Number(items[1]);
        let itemsHero = items[2].split(", ");
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
solve([
  "Isacc / 25 / Apple, GravityGun",
  "Derek / 12 / BarrelVest, DestructionSword",
  "Hes / 1 / Desolator, Sentinel, Antara"
]);
