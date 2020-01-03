function mathOperation(firstNumber, secondNumber, operator) {
    let operations = {
        '+': firstNumber + secondNumber,
        '-': firstNumber - secondNumber,
        '*': firstNumber * secondNumber,
        '/': firstNumber / secondNumber,
        '%': firstNumber % secondNumber,
        '**': firstNumber ** secondNumber
    };
    
    let result = operations[operator];

    console.log(result);
}
mathOperation(5,6, '*');