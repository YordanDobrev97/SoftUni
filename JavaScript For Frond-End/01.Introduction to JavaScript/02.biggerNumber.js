function getBiggestNumber(input) {
    let firstNumber = Number(input.shift());
    let secondNumber = Number(input.shift());
    let max = Math.max(firstNumber, secondNumber);
    return max;
}

let maxNumber = getBiggestNumber([10, 20]);
console.log(maxNumber);