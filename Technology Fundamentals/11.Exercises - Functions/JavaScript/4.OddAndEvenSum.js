function solve(number){
    let evenSum = getEvenDigitSum(number);
    let oddSum = getOddDigitSum(number);

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);

    function  getEvenDigitSum(number){
        let sum = 0;
        number = parseToNumber(number);

        while (hasDigits(number)) {
            let lastDigit = getLastDigit(number);
            if (lastDigit % 2 === 0) {
                sum = addToSum(sum, lastDigit);
            }
            number/=10;
            number = parseInt(number);
        }

        return sum; 
    }

    function getOddDigitSum(number){
        let sum = 0;
        number = parseToNumber(number);

        while (hasDigits(number)) {
            let lastDigit = getLastDigit(number);

            if (lastDigit % 2 === 1) {
                sum = addToSum(sum, lastDigit);
            }

            number/=10;
            number = parseInt(number);
        }

        return sum;
    }

    function addToSum(sum, lastDigit) {
        sum += lastDigit;
        return sum;
    }
    
    function getLastDigit(number) {
        return number % 10;
    }
    
    function hasDigits(number) {
        return number > 0;
    }
    
    function parseToNumber(number) {
        number = Number(number);
        return number;
    }
}
solve(1000435);
