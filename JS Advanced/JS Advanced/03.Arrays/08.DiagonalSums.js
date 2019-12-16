function diagonalSumMatrix(matrix) {
    let firstDiagonal = 0;

    for (let row = 0; row < matrix.length; row++) {
        let number = Number(matrix[row][row]);
        firstDiagonal += number;
    }

    let secondDiagonal = 0;
    let row = 0;
    for (let col = matrix.length - 1; col >= 0; col--) {
        let number = Number(matrix[row][col]);
        secondDiagonal += number;
        row++;
    }

    console.log(`${firstDiagonal} ${secondDiagonal}`);
}

diagonalSumMatrix([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]);