function diagonalSum(matrix){
    let sumNormalDiagonal = 0;
    let sumOtherDiagonal = 0;
    for(let row = 0; row< matrix.length; row++){
        let elementRow = matrix[row][row];
        sumNormalDiagonal +=elementRow;
        sumOtherDiagonal += matrix[row][matrix.length-row-1];
    }
    console.log(`${sumNormalDiagonal} ${sumOtherDiagonal}`);
}