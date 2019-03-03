let arr = [1,2,3];

function copiedArray() {
    let copied = Array.from(arr);

    console.log(`Copied array: ${copied}`);
    console.log(`Original array: ${arr}`);

    arr.push(5);

    console.log(`Copied array: ${copied}`);
    console.log(`Original array: ${arr}`);
}

function mapingArray() {
    let incrementValuesOfArr = Array.from(arr, x => x + 1);

    console.log(`Increment values: ${incrementValuesOfArr}`);
    console.log(`Original arr: ${arr}`);
}

function createArray() {
    let array = Array.from({length: 5}, (v, i) => i);
    console.log(`${array.join(' ')}`);
}
createArray();