function sumItems(array) {
    let firstItem = Number(array.shift());
    let lastItem = Number(array.pop());

    if (!lastItem) {
        lastItem = firstItem;
    }

    let sum = firstItem + lastItem;
    return sum;
}

console.log(sumItems(['10']));