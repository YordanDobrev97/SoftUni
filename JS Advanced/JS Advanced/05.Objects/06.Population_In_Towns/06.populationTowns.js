function solve(input) {
  let obj = {};

  for (let item of input) {
    let elements = item.split(" <-> ");
    let town = elements[0];
    let population = Number(elements[1]);

    if (!obj.hasOwnProperty(town)) {
        obj[town] = 0;
    }
    obj[town] += population;
  }

  for (let item in obj) {
    console.log(`${item} : ${obj[item]}`);
  }
}

solve([
  "Sofia <-> 1200000",
  "Montana <-> 20000",
  "New York <-> 10000000",
  "Washington <-> 2345000",
  "Las Vegas <-> 1000000"
]);
