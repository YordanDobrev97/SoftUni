function solve(input) {
  let resultObj = {};

  let last = undefined;
  let defaultValue = 0;
  input.forEach((value, index) => {
    if (index % 2 === 0) {
      if (!resultObj.hasOwnProperty(value)) {
        resultObj[value] = defaultValue;
      }
      last = value;
    } else {
      let income = Number(value);
      resultObj[last] += income;
    }
  });

  return JSON.stringify(resultObj);
}

console.log(solve(["Sofia", "20", "Varna", "3", "Sofia", "5", "Varna", "4"]));
console.log(solve(["Sofia", "20", "Varna", "3", "sofia", "5", "varna", "4"]));
