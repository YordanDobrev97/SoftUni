function evenOddSubtraction(array){
    let evenSum = 0;
    let oddSum = 0;

    for (let index = 0; index < array.length; index++) {
        const element = array[index];
        
        if(element % 2 == 0){
            evenSum += element;
        }else{
            oddSum += element;
        }
    }

    let diff = evenSum - oddSum;
    return diff;
}
let diff = evenOddSubtraction([1,2,3,4,5,6]);
console.log(diff);
