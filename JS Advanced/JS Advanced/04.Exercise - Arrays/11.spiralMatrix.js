function fillMatrix(rows, cols) {
  let matrix = [];
  //5, 5
  for (let row = 0; row < rows; row++) {
    matrix[row] = [cols];
    for (let col = 0; col < cols; col++) {
      matrix[row][col] = 0;
    }
  }

  let counter = 1;

  let currentRow = 0;
  let currentCol = 0;
  let isFillMatrix = false;
  while (true) {
    //right
    while (currentCol < cols) {
      if (matrix[currentRow][currentCol]) {
        isFillMatrix = true;
        break;
      } else {
        matrix[currentRow][currentCol++] = counter++;
        isFillMatrix = false;
      }
    }

    currentCol -= 1;
    let row = currentRow + 1;

    //down
    while (row < rows) {
      if (matrix[row][currentCol]) {
        isFillMatrix = true;
        break;
      } else {
        matrix[row++][currentCol] = counter++;
        isFillMatrix = false;
      }
    }

    currentCol -= 1;
    row -= 1;
    //left
    while (currentCol >= 0) {
      if (matrix[row][currentCol]) {
        isFillMatrix = true;
        break;
      } else {
        matrix[row][currentCol--] = counter++;
        isFillMatrix = false;
      }
    }
    row -= 1;
    currentCol += 1;
    while (row > currentRow) {
      if (matrix[row][currentCol]) {
        isFillMatrix = true;
        break;
      } else {
        matrix[row--][currentCol] = counter++;
        isFillMatrix = false;
      }
    }

    if (isFillMatrix) {
       break;
    }
    currentRow++;
    currentCol += 1;
  }

  for (let row = 0; row < matrix.length; row++) {
      const elements = matrix[row];
      console.log(elements.join(' '));
  }
}

fillMatrix(5, 5);
/*
    1  2  3  4  5
    16 17 18 19 6
    15 24 25 20 7
    14 23 22 21 8
    13 12 11 10 9
*/
