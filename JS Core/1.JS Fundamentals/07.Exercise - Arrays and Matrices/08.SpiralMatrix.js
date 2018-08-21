function spiralMatrix(row,col){
    // create matrix
    function createMatrix(row,col){
        let matrix = new Array(row);
        for(let i = 0; i < matrix.length; i++){
            matrix[i] = new Array(col); 
        }
        return matrix;
    }

    let matrix = createMatrix(row,col);
    let product = row * col;
    let r = 0;
    let c = 0;

    let count = 0;
    row--;
    while(count < product){
        for(let i =0; i < col; i++){
            matrix[r][c] = ++count;
            c++;
        }
        col--;
        c--;

        r++;
        for(let i = 0; i < row; i++){
            matrix[r][c] = ++count;
            r++;
        }
        row--;
        r--;

        c--;
        for(let i = 0; i < col; i++){
            matrix[r][c] = ++count;
            c--;
        }
        col--;
        c++;

        r--;
        for(let i = 0; i < row;i++){
            matrix[r][c] = ++count;
            r--;
        }
        row--;

        r++;
        c++;
    }
    matrix.forEach(e => console.log(e.join(' ')));
}