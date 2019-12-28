function multiplyTwoNumbers(array) {
    let firstNumber = Number(array.shift());
    let secondNumber = Number(array.shift());

    let result = firstNumber * secondNumber;
    return result;
}

console.log(multiplyTwoNumbers([2,3]));;