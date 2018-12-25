function arrayManipulator(arrayOfIntegers, arrayOfCommands){

    for(let item of arrayOfCommands)
    {
        let tokens = item.split(' ');
        let command = tokens.shift();
        switch(command){
            case 'add':
                add(Number(tokens[0]), Number(tokens[1]));
                break;
            case 'addMany':
                addMany(Number(tokens[0]), tokens)
                break;
            case 'contains':
                let element = Number(tokens[0]);
                if(contains(element)){
                    let index = arrayOfIntegers.indexOf(element);
                    console.log(index);
                }else{
                    console.log(-1);
                }
                break;
            case 'remove':
                let index = Number(tokens[0]);
                remove(index);
                break;
            case 'shift':
                let position = Number(tokens[0]);
                shift(position);
                break;
            case 'sumPairs':
                sumPairs();
                break;
            case 'print':
                console.log(`[ ${arrayOfIntegers.join(', ')} ]`);
                break;

        }
    }

    function contains(element){
        return arrayOfIntegers.includes(element);
    }

    function remove(index){
        arrayOfIntegers.splice(index, 1);
    }
    
    function shift(rotations){
        for (let index = 0; index < rotations; index++) {
            let first = arrayOfIntegers[0];
            moveItemsArray();
            arrayOfIntegers[arrayOfIntegers.length - 1] = first;
        }
        

        function moveItemsArray(){
            for(let i = 1; i < arrayOfIntegers.length; i++){
                arrayOfIntegers[i - 1] = arrayOfIntegers[i];
            }
        }
        
    }

    function sumPairs(){
        let result = [];

        for (let index = 0; index < arrayOfIntegers.length; index+=2) {
            const currentElement = arrayOfIntegers[index];
            const nextElement = arrayOfIntegers[index + 1];

            const sum = currentElement + nextElement;
            result.push(sum);
        }
        arrayOfIntegers = result;
    }

    function add(index, value){
        arrayOfIntegers.splice(index, 0, value);
    }

    function addMany(index, items){
        for (let i = 0; i < items.length - 1; i++) {
            const element = Number(items[i + 1]);
            arrayOfIntegers.splice(index, 0, element);
            index++;
        }
    }
}
arrayManipulator([2, 2, 4, 2, 4],["add 1 4", "sumPairs", "print"])
arrayManipulator([1, 2, 3, 4, 5],["addMany 5 9 8 7 6 5", "contains 15", "remove 3", "shift 1", "print"])
arrayManipulator([1, 2, 4, 5, 6, 7],["add 1 8", "contains 1", "contains -3", "print"]);