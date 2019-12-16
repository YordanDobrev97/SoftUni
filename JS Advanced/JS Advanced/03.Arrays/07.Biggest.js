function biggestElement(matrix) {
    let biggestItem = Number.MIN_SAFE_INTEGER;

    for (let row = 0; row < matrix.length; row++) {
        let insideMatrix = matrix[row].length;
        for (let col = 0; col < insideMatrix; col++) {
            let iteminsideMatrix = matrix[row][col];
            if (iteminsideMatrix >= biggestItem) {
                biggestItem = matrix[row][col];
            }
        }
    }

    return biggestItem;
} 

console.log(biggestElement([[3, 5, 7, 12],
    [-1, 4, 33,
    2],
    [8, 3, 0, 4]]));