function printStars(input) {
    let countStars = input;
    if (input === undefined) {
        countStars = 5;
    }

    let result = '';

    for (let row = 0; row < countStars; row++){
        for (let col = 0; col < countStars; col++) {
            result += '* ';
        }
        result += '\n';
    }

    console.log(result);
}
printStars();