function sumDigits(number){
    let numberAsString = number.toString();

    let sumOfDigits = 0;

    for (let index = 0; index < numberAsString.length; index++) {
        let element = numberAsString[index] - '0';
        sumOfDigits += element;
    }

    console.log(sumOfDigits);
}
sumDigits(111);