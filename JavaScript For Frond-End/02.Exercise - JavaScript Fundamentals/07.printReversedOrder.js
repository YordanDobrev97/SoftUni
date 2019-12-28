function printReversedOrder(array) {
    let reversedArray = array.slice();
    reversedArray.reverse();

    for(let item of reversedArray) {
        console.log(item);
    }
}

printReversedOrder([10, 15, 20]);