function arrayMap(array, cb) {
    const result = array.reduce((acc, val) => {
        acc.push(cb(val));
        return acc;
    }, []);

    return result;
};

let nums = [1,2,3,4,5];
console.log(arrayMap(nums,(item)=> item * 2)); // [ 2, 4, 6, 8, 10 ]
