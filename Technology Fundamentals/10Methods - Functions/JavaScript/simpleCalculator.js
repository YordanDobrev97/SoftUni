function simpleCalculator(firstNumber, secondNumber, operation){
    let func = undefined;
    let typeOperation = () => {
        if(operation === 'multiply'){
            func = () =>firstNumber * secondNumber; 
        }else if(operation === 'divide'){
            func = () =>firstNumber / secondNumber; 
        }else if(operation === 'add'){
            func = () =>firstNumber + secondNumber; 
        }else{
            func = () =>firstNumber - secondNumber; 
        }
        console.log(func(firstNumber, secondNumber));
    }
    typeOperation();
}
simpleCalculator(5,5,'multiply');