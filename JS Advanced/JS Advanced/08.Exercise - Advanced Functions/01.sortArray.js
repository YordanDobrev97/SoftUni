function solve(array, typeOrder) {
    const sortedArray = function(array, typeOrder) {
        if (typeOrder === 'asc') {
            return array.sort((a,b) => a - b);
        }
        return array.sort((a,b) => b - a);
    };
    let resultArray = sortedArray(array, typeOrder);
    return resultArray;
}

solve([3, 1, 2, 10],'asc');