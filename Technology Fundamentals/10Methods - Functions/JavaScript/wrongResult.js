function wrongResult(firstNumber, secondNumber, thirdNumber){
    let product = firstNumber * secondNumber * thirdNumber;

    if(product < 0){
        console.log('Negative');
    }else{
        console.log('Positive');
    }
}
wrongResult(-1, 0, 1);