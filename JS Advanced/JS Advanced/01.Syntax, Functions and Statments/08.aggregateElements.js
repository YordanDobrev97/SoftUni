function aggregateElements(array) {
    let sumArray = sum(array);
    let sumInverse = inverseSum(array);
    let values = concatValues(array);

    console.log(sumArray);
    console.log(sumInverse);
    console.log(values);

    function sum(array){
        let sum = array.reduce((a,b) => a + b);
        return sum;
    }

    function inverseSum(array) {
        let reversed = array.reverse();
        let sumInverse = reversed.reduce((result, num) => result + 1 / num);
        return sumInverse;
    }

    function concatValues(array) {
        let result = array.join('');
        return result;
    }
}

aggregateElements([1, 2, 3]);
aggregateElements([2, 4, 8, 16]);