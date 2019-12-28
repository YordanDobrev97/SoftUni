function productOfNumbers(firstNumber, secondNumber, thirdNumber) {
    let result = firstNumber * secondNumber * thirdNumber;

    if (result > 0) {
        console.log('Positive');
    } else {
        console.log('Negative');
    }
}
productOfNumbers(2, 3, -1);