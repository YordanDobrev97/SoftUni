
function solve(input) {
    //number characters 
    //Consists letters and digits
    //at least 2 digits 

    let isHasValidPassword = true;
    if (!validNumberCharacters(input)) {
        console.log(`Password must be between 6 and 10 characters`);
        isHasValidPassword = false;
    }

    if (!consistsLettersAndDigits(input)) {
        console.log(`Password must consist only of letters and digits`);
        isHasValidPassword = false;
    }

    if (!leastTwoDigits(input)) {
        console.log(`Password must have at least 2 digits`);
        isHasValidPassword = false;
    }

    if (isHasValidPassword){
        console.log(`Password is valid`);
    }


    function validNumberCharacters(input){
        return input.length >= 6 && input.length <= 10;
    }

    function consistsLettersAndDigits(input){
        let containsLetters = isLetter(input);
        let containsDigits = isDigits(input);
        if (containsLetters || containsDigits) {
            return true;
        }

        return false;
    }

    function isLetter(input){
        let numberRangeOfLettersAscii = [];

        //Upper letter
        const startUpperLetterAscii = 65;
        const endUpperLetterAscii = 90;
        for (let i = startUpperLetterAscii; i <=endUpperLetterAscii; i++) {
           numberRangeOfLettersAscii.push(i);
        }

        //lower letter
        const startLowerLetterAscii = 97;
        const endLowerLetterAscii = 122;
        for (let i = startLowerLetterAscii; i <=endLowerLetterAscii; i++) {
            numberRangeOfLettersAscii.push(i);
        }

        let isHaveOnlyLetter = false;
        for(let item of input) {
            let symbol = item.charCodeAt(0);

            if (numberRangeOfLettersAscii.includes(symbol)) {
                isHaveOnlyLetter = true;
            }else {
                isHaveOnlyLetter = false;
                break;
            }
        }

        return isHaveOnlyLetter;
    }

    function isDigits(input){
        let numberRangeOfNumbersAscii = [];

        const startRangeNumberAscii = 48;
        const endRangeNumberAscii = 57;
        for (let i = startRangeNumberAscii; i <=endRangeNumberAscii; i++) {
            numberRangeOfNumbersAscii.push(i);
        }

        let isHaveDigits = false;
        for(let item of input) {
            let symbol = item.charCodeAt(0);

            if (numberRangeOfNumbersAscii.includes(symbol)) {
                isHaveDigits = true;
            }
        }

        return isHaveDigits;
    }

    function leastTwoDigits(input) {
        let count = 0;
        for(let item of input) {
            if (isDigits(item)) {
                count++;
            }
        }

        if (count >= 2){
            return true;
        }

        return false;
    }
}
solve('MyPass123');