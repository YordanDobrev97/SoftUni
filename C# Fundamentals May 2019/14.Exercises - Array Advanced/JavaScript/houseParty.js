function houseParty(input){
    let guests = [];

    for (let index = 0; index < input.length; index++) {
        const element = input[index];
        let name = element.split(' ')[0];
        if(element.includes('not going!')){
            if(guests.includes(name)){
                guests = guests.filter(el => el !== name);
            }else{
                console.log(`${name} is not in the list!`);
            }
        }else{
            if(!guests.includes(name)){
                guests.push(name);
            }else{
                console.log(`${name} is already in the list!`);
            }
        }
    }
    guests.forEach(guest => console.log(guest));
}
houseParty(['Allie is going!','George is going!',
'John is not going!', 'George is not going!'])