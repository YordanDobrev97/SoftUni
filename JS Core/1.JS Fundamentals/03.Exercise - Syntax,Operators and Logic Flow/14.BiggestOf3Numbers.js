function biggestNumbers(array){
    let num1 = array[0];
    let num2 = array[1];
    let num3 = array[2];

    let biggestNumber = num1;
    if(num2 > num1 && num2 > num3){
        biggestNumber = num2;
    }else if(num3 > num1 && num3 > num2){
        biggestNumber = num3;
    }
    console.log(biggestNumber);
}