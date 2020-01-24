function add(number) {
    let initialValue = number;
    return function(value) {
        return initialValue + value;
    }
}

let num = add(5);
console.log(num(2));
console.log(num(3));
