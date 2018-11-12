function sumEvenNumbers(array){
    let evenSum = 0;
    for (let index = 0; index < array.length; index++) {
        const element = Number(array[index]);
        
        if(element % 2 == 0){
            evenSum += element;
        }
    }
    return evenSum;
}
let sum = sumEvenNumbers(['1', '2', '3', '4', '5', '6']);
console.log(sum);