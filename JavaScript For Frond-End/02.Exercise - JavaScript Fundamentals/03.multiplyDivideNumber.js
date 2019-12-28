function multiplyDivideNumber(array) {
    let n = Number(array.shift());
    let x = Number(array.shift());

    if (x >= n) {
        return x * n;
    }
    return n / x;
}

console.log(multiplyDivideNumber([2,3]));