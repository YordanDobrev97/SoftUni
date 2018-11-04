function solve(number){

    for (let index = 1; index <=number; index++) {
        let isSpecialNumber = specialNumber(index);
        if(isSpecialNumber){
            console.log(`${index} -> True`);
        }else{
            console.log(`${index} -> False`);
        }
    }

    function specialNumber(num){
        let sum = totalSum(num);

        if(sum === 5 || sum === 7 || sum === 11){
            return true;
        }
        return false;
    }
    function totalSum(num){
        let convertToString = num.toString();

        let sum = 0;

        for (let index = 0; index < convertToString.length; index++) {
           const element = convertToString[index];
           sum += Number(element);
        }
        return sum;
    }
}
solve(15);