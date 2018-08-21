function rotateArray(array){
    let rotationsCount = array.pop() % array.length;

    for (let i = 0; i < rotationsCount; i++) {
        array.unshift(array.pop());
    }

    console.log(array.join(' '));
}