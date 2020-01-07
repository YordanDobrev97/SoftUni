function rotateArray(array) {
    let countRotations = Number(array.pop()) % array.length;

    for (let i = 0; i < countRotations; i++) {
        let last = array.pop();
        array.unshift(last);
    }

    console.log(array.join(' '));
}
rotateArray([
    '1', '2', '3','4', '2'
]);
