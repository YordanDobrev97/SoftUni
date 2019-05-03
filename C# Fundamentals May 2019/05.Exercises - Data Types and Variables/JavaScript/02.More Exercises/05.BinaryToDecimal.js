function fromBinaryToDecimal(binaryNumber) {
    let parseToNumber = parseInt(binaryNumber);
    let index = 0;
    let result = 0;

    while (parseToNumber > 0){
        let lastDigit = parseToNumber % 10;

        if (lastDigit !== 0) {
            result += Math.pow((lastDigit * 2), index);
        }

        index++;
        parseToNumber /=10;
        parseToNumber = parseInt(parseToNumber);
    }

    console.log(result.toFixed(0));
}
fromBinaryToDecimal('11110000');