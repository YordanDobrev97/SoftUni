function functionalSum(num = 0){
    let sum = num;
    function add(n){
        sum +=n;
        return add;
    }
    add.toString = () => sum;
    return add;
};
let result = functionalSum(1)(6)(-3).toString();
console.log(result);