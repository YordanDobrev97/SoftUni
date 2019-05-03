function biggestNumber(firstNumber,secondNumber, thirdNumber) {
    let currentBiggest = Math.max(firstNumber, secondNumber);
    let totalBiggest = Math.max(currentBiggest, thirdNumber);

    console.log(totalBiggest);
}
biggestNumber(10,2,3);