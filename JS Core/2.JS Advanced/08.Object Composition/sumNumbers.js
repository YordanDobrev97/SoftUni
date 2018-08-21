function sum(){
    let firstNumberValue = $('#num1').val();
    let secondNumberValue = $('#num2').val();
    let result = $('#result');
    
    let sumBtn = $('#sumButton');
    let subtrackBtn = $('#subtractButton');

    sumBtn.on('click', function(){
        let sum = Number(firstNumberValue) + Number(secondNumberValue);
        result.val(sum + '');
    });
    subtrackBtn.on('click', function(){
        let diff = Number(firstNumberValue) - Number(secondNumberValue);
        result.val(diff + '');
    })
}