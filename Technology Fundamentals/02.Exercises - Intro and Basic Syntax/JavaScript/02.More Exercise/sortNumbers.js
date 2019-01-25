function sortNumbers(firstNumber, secondNumber, thirdNumber){
    
    let maxNumber = Math.max((Math.max(firstNumber, secondNumber)), thirdNumber);
    let minNumber = Math.min((Math.min(firstNumber, secondNumber)), thirdNumber);
    let middleNumber = getMiddleNumber(maxNumber, minNumber, firstNumber, secondNumber, thirdNumber);

    console.log(`${maxNumber}`);
    console.log(`${middleNumber}`);
    console.log(`${minNumber}`);
    
    function getMiddleNumber(maxNumber, minNumber, firstNumber, secondNumber, thirdNumber){

        /*
        algorithm

        examples
        |f | s | t |
        |10| 15| 20|
        ____________
        max - 20
        min - 10
        ____________
        5 2 40
        ____________
        max - 40
        min - 2
        ____________
        pseudocode
            
        if firstNumber === maxNumber
            if secondNumber === minNumber than middle number is thirdNumber
            else thirdNumber === minNumber than middle number is secondNumber
        else if secondNumber === maxNumber
            if firstNumber === minNumber than middle number is third number
            else thirdNumber == minNumber than middle number is first number
        else if thirdNumber === maxNumber
            if firstNumber === minNumber than middle number is second number
            else secondNumber === minNumber than middle numberis first number
        */

        let middleNumber = undefined;

        if(firstNumber === maxNumber){
            if(secondNumber === minNumber){
                middleNumber = thirdNumber;
            }else{
                middleNumber = secondNumber;
            }
        }else if(secondNumber === maxNumber){
            if(firstNumber === minNumber){
                middleNumber = thirdNumber;
            }else{
                middleNumber = firstNumber;
            }
        }else if(thirdNumber === maxNumber){
            if(firstNumber === minNumber){
                middleNumber = secondNumber;
            }else {
                middleNumber = firstNumber;
            }
        }

        return middleNumber;
    }

}
sortNumbers(2,1,3); // 3 2 1
sortNumbers(5,10,2); // 10 2 5
sortNumbers(18,9,-4); // 18 -4 9