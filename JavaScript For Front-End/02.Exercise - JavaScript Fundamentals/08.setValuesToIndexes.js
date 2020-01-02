function setValuesToIndexes(input) {
    let lengthArray = Number(input.shift());

    let array = [];
    for (let i = 0; i < input.length; i++) {
        let args = input[i].split(' - ');
        let index = Number(args[0]);
        let value = Number(args[1]);

        array[index] = value;
    }

    if (array.length < lengthArray) {
        for (let i =0; i < lengthArray - array.length;i++) {
            array.push(0);
        }
    }

    for(let item of array)  {
        if (item === undefined) {
            console.log(0);
        } else {
            console.log(item);
        }
    }
}
//setValuesToIndexes([ '5', '0 - 3', '3 - -1', '4 - 2']);
//setValuesToIndexes([ '3', '0 - 5', '1 - 6', '2 - 7' ]);
setValuesToIndexes([ '2', '0 - 5', '0 - 6', '0 - 7' ]);
