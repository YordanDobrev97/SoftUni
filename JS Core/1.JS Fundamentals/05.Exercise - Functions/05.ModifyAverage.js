function modifiAverage(number){
    let strNumber = number.toString();

    while(true)
    { 
        let sum = 0;
        for(let i=0; i<strNumber.length; i++){
            sum = newFunction(sum, i);
        }
        if((sum / strNumber.length) <=5){
            strNumber +='9';
        }else {
            break;
        }
    }
    console.log(strNumber);

    function newFunction(sum, i) {
        sum += Number(strNumber[i]);
        return sum;
    }
}