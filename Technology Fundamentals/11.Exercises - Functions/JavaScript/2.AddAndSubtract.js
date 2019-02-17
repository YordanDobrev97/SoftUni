function solve(firstNumber, secondNumber, thirdNumber){

    let sum = addNumbers(firstNumber, secondNumber);
    let result = subtract(sum, thirdNumber);

    return result;

    function subtract(first, second){
        return first - second;
    }

    function addNumbers(firstNumber, secondNumber){
        return firstNumber + secondNumber;
    }
}
let sum = solve(1,2,3);
console.log(sum);
