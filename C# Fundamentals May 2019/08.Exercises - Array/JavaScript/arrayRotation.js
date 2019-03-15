function arrayRotations(array, rotations) {

    for (let index = 0; index < rotations; index++) {
        const first = array.shift();
        array.push(first);
    }

    console.log(array.join(' '));
}
arrayRotations([51, 47, 32, 61, 21],2);