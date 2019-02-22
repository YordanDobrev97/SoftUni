function solve(number) {
    if (number === 100) {
        console.log(`100% Complete!`);
        console.log(`[%%%%%%%%%%]`);
    }else{
        let percentages = number / 10;
        let output = `${number}% [`;

        for (let i = 0; i < percentages; i++) {
            output += `%`;
        }
        let maxPercentages = 10;
        let points = maxPercentages - percentages;

        for (let i = 0; i < points; i++) {
            output += `.`;
        }
        output += ']';

        console.log(output);
        console.log(`Still loading...`);
    }
}
solve(100);