function sorting(input){
    let sortNumbers = input.sort((a,b) => a - b);

    let result = [];

    while(sortNumbers.length > 0){
        let maxElement = sortNumbers.pop();
        let minElement = sortNumbers.shift();

        result.push(maxElement);
        result.push(minElement);
    }
    console.log(result.join(' '));


}
sorting([1, 21, 3, 52, 69, 63, 31, 2, 18, 94])