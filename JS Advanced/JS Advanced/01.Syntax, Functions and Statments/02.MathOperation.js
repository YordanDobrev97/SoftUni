function calculateExpression(firstNumber, secondNumber, operator){
    switch (operator) {
        case '+':
            return firstNumber + secondNumber;
        case '-':
            return firstNumber - secondNumber;
        case '*':
            return firstNumber * secondNumber;
        case '/':
            return firstNumber / secondNumber;
        case '%':
            return firstNumber % secondNumber;
        case '**':
            return firstNumber ** secondNumber;
    }
}

console.log(calculateExpression(5,6, '+'));
console.log(calculateExpression(3, 5.5, '**'));