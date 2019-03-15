function getSmallestNumber(firstNumber, secondNumber, thirdNumber){
    let currentMin = getMin(firstNumber, secondNumber);
    let finalyMin = getMin(currentMin, thirdNumber);

    return finalyMin;

    function getMin(firstNumber, secondNumber){
        return Math.min(firstNumber, secondNumber);
    }
}
let number = getSmallestNumber(1,2,3);
console.log(number);
