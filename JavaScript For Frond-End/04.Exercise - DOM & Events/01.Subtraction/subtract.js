function subtract() {
    let firstNumberValue  = document.getElementById('firstNumber').value;
    let secondNumberValue = document.getElementById('secondNumber').value;
    
    let result = firstNumberValue - secondNumberValue;
    let resultDiv = document.getElementById('result');

    resultDiv.textContent = result;
}