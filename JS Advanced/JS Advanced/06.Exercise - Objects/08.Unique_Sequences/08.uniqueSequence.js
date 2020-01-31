function solve(input) {
  const uniqueSums = {};
  const uniqueArrays = [];

  let index = 0;
  for (let item of input) {
    let array = JSON.parse(item);
    let sum = array.reduce((acc, value) => acc + value, 0);

    if (!uniqueSums.hasOwnProperty(sum)) {
      uniqueSums[sum] = { index };
      uniqueArrays.push(array);
    }
  }

  uniqueArrays.sort((a, b) => {
    return a.length - b.length;
  });

  for (let array of uniqueArrays) {
    let sorted = array.sort((a, b) => {
      return b - a;
    });
    console.log(`[${sorted.join(", ")}]`);
  }
}

solve([
  "[1, 0, 0, -1]",
  "[10, 1, -17, 0, 2, 13]",
  "[4, -3, 3, -2, 2, -1, 1, 0]"
]);
