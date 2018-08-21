function sortArray(array, sorting){

    let sortFunc = {
        asc: (array) => array.sort((a, b) => a - b),
        desc: (array) => array.sort((a,b) => b - a)
    }
    let sort = sortFunc[sorting];
    return sort(array);
}
let result = sortArray([14, 7, 17, 6, 8], 'asc');
console.log(result);