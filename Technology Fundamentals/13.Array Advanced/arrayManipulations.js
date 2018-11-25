function manipulations(input){
    let numbers = input.shift();
    let items = numbers.split(' ').map(Number)
    
    for(let args of input)
    {
       let command = args.split(' ')[0];
       let value = Number(args.split(' ')[1]);

       switch(command){
        case 'Add':
            add(value);
            break;
        case 'Remove':
            remove(value);
            break;
        case 'RemoveAt':
            removeAt(value);
            break;
        case 'Insert':
            let index = Number(args.split(' ')[2]);
            insert(value,index);
            break;
       }
    }

    console.log(items.join(' '));

    function add(element){
        items.push(element);
    }

    function remove(element){
        items = items.filter(el => el !== element);
    }

    function removeAt(index){
        items.splice(index,1);
    }

    function insert(element, index){
        items.splice(index, 0, element);
    }
}


manipulations(['4 19 2 53 6 43', 'Add 3', 'Remove 2', 'RemoveAt 1','Insert 8 3']);