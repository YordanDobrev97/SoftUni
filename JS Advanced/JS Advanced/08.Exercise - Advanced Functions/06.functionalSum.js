let solve = (function() {
    let sum = 0;
    return function add(value) {
        sum += value;

        add.toString = function() {
            return sum;
        };

        return add;
    };
});

let add = solve();
let sum = add(1)(2)(3);

console.log(sum.toString());