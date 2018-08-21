function calcSum(){
    let num1Value = document.getElementById("num1").value;
    let num2Value = document.getElementById("num2").value;
    let sum = Number(num1Value) + Number(num2Value);
    document.getElementById('sum').value = sum;
}