function gladiatorInventory(input){
    let inventory = [];
    let items = input.shift().split(' ');

    for(let item of items){
        inventory.push(item);
    }
    
    for(let command of input){
        let elements = command.split(' ');
        switch(elements[0]){
            case 'Buy':
                inventory.push(elements[1]);
                break;
            case 'Trash':
                remove(elements[1]);
                break;
            case 'Repair':
                if(contains(elements[1])){
                    remove(elements[1]);
                    inventory.push(elements[1]);
                }
                break;
            case 'Upgrade':
                let equipment = elements[1].split('-')[0];
                let upgrade = elements[1].split('-')[1];
                if(contains(equipment)){
                    insert(equipment, upgrade);
                }
                break;

        }
    }

    console.log(inventory.join(' '));

    function remove(element){
        if(contains(element)){
            let index = findIndex(element);
            inventory.splice(index, 1);
        }
    }

    function contains(data){
        if(inventory.includes(data)){
            return true;
        }
        return false;
    }

    function insert(oldData, replaceData){
        let index = findIndex(oldData);
        let nextIndex = index + 1;
        replaceData = `${oldData}:${replaceData}`;
        inventory.splice(nextIndex, 0, replaceData);
    }

    function findIndex(data){
        return inventory.indexOf(data);
    }
}
gladiatorInventory(['SWORD Shield Spear',
'Trash Bow',
'Repair Shield',
'Upgrade Helmet-V'
]);

gladiatorInventory(['SWORD Shield Spear',
'Buy Bag',
'Trash Shield',
'Repair Spear',
'Upgrade SWORD-Steel']);