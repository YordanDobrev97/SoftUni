function  subtract() {
    let firstValue = document.getElementById('firstNumber').value;
    let secondValue = document.getElementById('secondNumber').value;

    let subtract = Number(firstValue) - Number(secondValue);
    let result = document.getElementById('result');
    result.textContent = subtract;
}