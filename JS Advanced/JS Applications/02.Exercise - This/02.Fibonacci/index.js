function getFibonator() {
    let first = 0;
    let second = 1;
    return function() {
        const currentResult = first + second;
        first = second;
        second = currentResult;
        return first;
    }
}

const fib = getFibonator();
console.log(fib());
console.log(fib());
console.log(fib());
console.log(fib());
