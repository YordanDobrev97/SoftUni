function oddEven(number){
    let parseToInt = parseInt(number);  
    let isValidNumber = true; 
    if(parseToInt != number){
        isValidNumber = false;
    }
    if(!isValidNumber){
        console.log('invalid');
    }else{
        if(number % 2 == 0){
            console.log('even')
        }else if(number % 2 != 0){
            console.log('odd');
        }  
    }  
}