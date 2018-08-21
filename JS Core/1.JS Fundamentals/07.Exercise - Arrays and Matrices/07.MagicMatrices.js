function magicMatrix(matrix){
    let sum = 0;
    for(let row = 0;row < matrix.length; row++){
        for(let col = 0; col < matrix[0].length; col++){
            let item = matrix[row][col];
            sum +=item;
        }
        break;
    }
    let currentSum = 0;
    let isAllEquals = true;
    for(let row = 1; row < matrix.length; row++){
        for(let col = 0; col < matrix[0].length; col++){
            let item = matrix[row][col];
            currentSum +=item;
        }
        if(currentSum != sum){
            isAllEquals = false;
            break;
        }else{
            isAllEquals = true;
            currentSum = 0;
        }
    }
    console.log(isAllEquals);
}