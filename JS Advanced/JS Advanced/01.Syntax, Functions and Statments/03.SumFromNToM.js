function sumOfNumbers(start, end) {
    let sum = 0;
    let n = Number(start);
    let m = Number(end);
    
    for (let i = n; i <=m; i++) {
        sum += i;
    }

    return sum;
}

console.log(sumOfNumbers('1', '5'));