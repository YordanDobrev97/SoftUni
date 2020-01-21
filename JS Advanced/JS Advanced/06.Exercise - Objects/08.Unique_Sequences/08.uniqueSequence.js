function solve(input) {
  const result = [];
  const items = input.map(el => JSON.parse(el));

  for (let item of items) {
    const sum = sumElements(item);

    if (!existSum(sum, result, item)) {
        result.push([...item]);
    }
  }

  let sorted = result.sort((a,b) => {
      a.sort((x, y) => {
          return (y + ''.length) - (x + ''.length);
      });
      b.sort((x, y) => {
          return (y+''.length) - (x + ''.length);
      });
      return a.length - b.length;
  });

  for(let array of sorted) {
    console.log(`[${array.join(', ')}]`);
  }


  function sumElements(collection) {
    return collection.reduce((a, b) => {
        return a + b;
      }, 0);
  }

  function existSum(sum, result, item) {
      for(let item of result) {
         let currentSum = sumElements(item);
         if (currentSum === sum) {
             return true;
         }
      }
      return false;
  }
}

solve(["[-3, -2, -1, 0, 1, 2, 3, 4]",
"[10, 1, -17, 0, 2, 13]",
"[4, -3, 3, -2, 2, -1, 1, 0]"]
);
