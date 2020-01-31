function subtract() {
    const firstNumber = document.getElementById('firstNumber').value;
    const secondNumber = document.getElementById('secondNumber').value;
    const result = firstNumber - secondNumber;
    
    document.getElementById('result').textContent = result;
}