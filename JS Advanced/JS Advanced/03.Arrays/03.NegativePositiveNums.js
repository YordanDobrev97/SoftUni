function insertNegativeNumsFront(array) {
    let resultArray = [];

    for(let item of array) {
        if (item < 0) {
            resultArray.unshift(item);
        } else {
            resultArray.push(item);
        }
    }

    for (let item of resultArray) {
        console.log(item);
    }
}
insertNegativeNumsFront([3, -2, 0, -1]);