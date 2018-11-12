function mergeArray(firstArray, secondArray){
    let mergeArray = [];

    let min = Math.min(firstArray.length, secondArray.length);

    for (let index = 0; index < min; index++) {
        let firstElement = firstArray[index];
        let secondElement = secondArray[index];
        if(index % 2 == 0){
            let sum = Number(firstElement) + Number(secondElement);
            mergeArray.push(sum);
        }else{
            let concat = `${firstElement}${secondElement}`;
            mergeArray.push(concat);
        }
    }
    console.log(mergeArray.join(' - '));
}
mergeArray(['5', '15', '23', '56', '35'], ['17', '22', '87', '36', '11']);