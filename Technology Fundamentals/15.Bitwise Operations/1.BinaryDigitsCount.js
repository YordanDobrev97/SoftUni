function solve(number, countBinaryDigit){
    let toBinary = number.toString(2);
    let count = 0;
    
    while (toBinary > 0){
        let digit = toBinary % 10;

        if (digit === countBinaryDigit) {
            count++;
        }
        toBinary/=10;
        toBinary = parseInt(toBinary);
    }

    console.log(count);
}
solve(20, 0);
solve(15,1);
solve(10,0);
