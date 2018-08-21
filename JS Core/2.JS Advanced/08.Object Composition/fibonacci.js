function getFibonacii(){
    let first = 0;
    let second = 1;
    return function(){
        let sum = first + second;
        first = second;
        second = sum;
        return first;
    }
};
let result = getFibonacii();
console.log(result());
console.log(result());
console.log(result());
console.log(result());
console.log(result());
console.log(result());
console.log(result());
console.log(result());