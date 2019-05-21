function solve(input) {
    let size = input.shift();
    let indexes = input.shift().split(' ');
    let commands = input;

    let array = [];

    for(let i = 0; i<size;i++) {
        let value = Number(indexes[i]);
        if (!isNaN(value)) {
            array[value] = 1; 
        } else {
           array.push(undefined);
           if (array.length === size) {
               break;
           }
        }
    }

    for(let item of commands) {
        let arguments = item.split(' ');
        let startIndex = Number(arguments[0]);
        let command = arguments[1];
        let endIndex = Number(arguments[2]);

        if (command === 'right') {
            if ((startIndex + endIndex) >= array.length) {
                array[startIndex] = undefined;
            } else  {
                let foundFreePlace = false;
                while (startIndex <=endIndex && endIndex < array.length) {
                    if (array[endIndex] != undefined) {
                        endIndex++;
                        foundFreePlace = true;
                    } else  {
                        let startValue = array[startIndex];
                        array[endIndex] = startValue;
                        array[startIndex] = undefined;
                        foundFreePlace = false;
                    }
                }
                if (foundFreePlace) {
                    array[startIndex] = undefined;
                }
            }
        } else if (command === 'left') {
            if (startIndex - endIndex > array.length) {
                continue;
            }
            while (endIndex >= 0) {
                if (array[startIndex] === undefined) {
                    endIndex--;
                } else {
                    let value = array[startIndex];
                    array[startIndex - endIndex] = value;
                    array[startIndex] = undefined;
                    break;
                }
            }
        }
    }

    let output = '';

    for(let item of array) {
        if (item === undefined) {
            output += '0 ';
        } else {
            output += '1 ';
        }
    }

    console.log(output);
}
//solve([5, '3', '3 left 2']);
solve([5, '3', '3 left 2', '1 left -2']);
solve([3, '0 1 2', '0 right 1', '1 right 1', '2 right 1']);
solve([3, '0 1', '0 right 1', '2 right 1']);