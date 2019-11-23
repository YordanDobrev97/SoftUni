function getLargestNumber(firstNumber, secondNumber, thirdNumber) {
    let currentMax = Math.max(firstNumber, secondNumber);
    let finalyMax = Math.max(currentMax, thirdNumber);

    return `The largest number is ${finalyMax}.`;
}

console.log(getLargestNumber(5, -3, 16));

