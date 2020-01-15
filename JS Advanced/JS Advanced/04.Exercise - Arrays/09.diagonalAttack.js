function diagonalAttackMatrix(input) {
    let matrix = parseMatrixToNumber(input);

    let firstSum = firstDiagonalSum(matrix);
    let secondSum = secondDiagonalSum(matrix);

    if (firstSum === secondSum) {
        changeMatrix(matrix, firstSum);
    }

    printMatrix(matrix);

    function firstDiagonalSum(matrix) {
        let sum = 0;
        for (let row = 0; row < matrix.length; row++) {
            const element = matrix[row][row];
            sum += element;
        }

        return sum;
    }

    function secondDiagonalSum(matrix) {
        let sum = 0;
        let col = 0;
        for (let row = 0; row < matrix.length; row++) {
            let colElement  = matrix[row].slice().reverse()[col];
            sum += colElement;
            col++;
        }
        return sum;
    }

    function changeMatrix(matrix, sum) {
        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix[row].length; col++) {
                let specialCol = matrix[row].length - row - 1;
                if (row !== col && col !== specialCol) {
                    matrix[row][col] = sum;
                }
            }
        }
    }

    function printMatrix(matrix) {
        for (let row = 0; row < matrix.length; row++) {
            const elements = matrix[row];
            console.log(elements.join(' '));
        }
    }

    function parseMatrixToNumber (input) {
        let result = [];

        for (let row = 0; row < input.length; row++) {
            let currentRow = input[row].split(' ').map(x => Number(x));
            result.push(currentRow);
        }

        return result;
    };
}

diagonalAttackMatrix(
    ['1 1 1',
    '1 1 1',
    '1 1 0']
)