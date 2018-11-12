function sumFirstLastElement(array) {
    let first = Number(array[0]);
    let last = Number(array[array.length - 1]);

    let sum = first + last;
    return sum;
}
let sum = sumFirstLastElement([20,0,40]);
console.log(sum);