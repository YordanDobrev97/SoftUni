function solve(input){

    //number characters 
    //Consists letters and digits
    //at least 2 digits 
    if (!validNumberCharacters(input)) {
        console.log(`Password must be between 6 and 10 characters`);
    }


    function validNumberCharacters(input){
        return input.length >= 6 && input.length <= 10;
    }

    function consistsLettersAndDigits(input){
        
    }
}