function magicMatrices(input) {
  function sumArray(length, array) {
    let sum = 0;

    for (let col = 0; col < length; col++) {
      let item = array[col];
      sum += item;
    }
    return sum;
  }

  let arrayRow = function(length, matrix, col) {
    let arrayRow = [];

    for (let i = 0; i < length; i++) {
      const element = matrix[i][col];
      arrayRow.push(element);
    }
    return arrayRow;
  };

  let isMagic = true;

  for (let row = 0; row < input.length; row++) {
    const elementsCol = input[row];
    const elementsRow = arrayRow(input.length, input, row);

    let colSum = sumArray(input[row].length, elementsCol);
    let rowSum = sumArray(input.length, elementsRow);

    if (colSum !== rowSum) {
      isMagic = false;
      break;
    }
  }

  console.log(isMagic);
}

magicMatrices([
  [11, 32, 45],
  [21, 0, 1],
  [21, 1, 1]
]);
