function processOddNums(array) {
    let resultArray = [];
    for (let i = 0; i < array.length; i++) {
        if (i % 2 == 1) {
            let number = array[i];
            let doubleNumber = number * 2;
            resultArray.unshift(doubleNumber);
        }
    }

    console.log(resultArray.join(' '));
}

processOddNums([3, 0, 10, 4, 7, 3]);