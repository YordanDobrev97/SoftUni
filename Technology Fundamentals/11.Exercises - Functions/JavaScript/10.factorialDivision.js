function solve(firstNumber, secondNumber) {
    let factorialFirstNumber = factorial(firstNumber);
    let factorialSecondNumber = factorial(secondNumber);

    let divide = factorialFirstNumber / factorialSecondNumber;
    console.log(divide.toFixed(2));

    function factorial(n) {
        if(n == 0) {
            return 1
        } else {
            return n * factorial(n - 1);
        }
    }
}
solve(5,2);