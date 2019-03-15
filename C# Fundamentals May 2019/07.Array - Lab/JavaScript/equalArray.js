function equalArray(firstArray, secondArray){
    let hasAllEqualElements = false;

    let diffIndex = 0;
    let sum = 0;
    let min = Math.min(firstArray.length, secondArray.length);
    for (let index = 0; index < min; index++) {
        let elementFromFirstArray = Number(firstArray[index]);
        let elementFromSecondArray = Number(secondArray[index]);

        if(elementFromFirstArray !== elementFromSecondArray){
            hasAllEqualElements = true;
            diffIndex = index;
            break;
        }
        sum += elementFromFirstArray;
    }

    if(!hasAllEqualElements){
        console.log(`Arrays are identical. Sum: ${sum}`);
    }else{
        console.log(`Arrays are not identical. Found difference at ${diffIndex} index`);
    }

}
equalArray(['10', '20', '30'],['10', '20', '30']);
equalArray(['1', '2', '3', '4', '5'], ['1', '2', '4', '4', '5'])