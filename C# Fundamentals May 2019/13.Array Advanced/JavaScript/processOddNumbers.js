function processingOddNumbers(array){
    let result =array
    .filter((x, pos) => pos % 2 == 1)
    .map(num => num * 2)
    .reverse();

    console.log(result.join(' '));
}
processingOddNumbers([3, 0, 10, 4, 7, 3]);