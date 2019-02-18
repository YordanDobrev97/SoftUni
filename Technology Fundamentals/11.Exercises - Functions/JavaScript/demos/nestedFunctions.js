function solve(){  

    processingNumbers();

    function processingNumbers(){
        let multiplyNums = multiplyNumbers(10,10);
        let divideNums = divideNumbers(10,10);
    }
    //console.log(varVariable);

    function multiplyNumbers(first, second){

        console.log(varVariable);

        var varVariable = 'var';
        return first * second;
    }

    function divideNumbers(first, second){
        if(first === 0 || second === 0){
            return 'Not divide zero';
        }
        return first / second;
    }
}
solve();