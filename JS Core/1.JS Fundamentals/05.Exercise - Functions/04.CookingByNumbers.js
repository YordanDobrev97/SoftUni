function cookingNumbers(items){
    let number = items[0];
    for(let i = 1; i<items.length;i++) {
        let command = items[i];
        if(command === 'chop'){
            // divide number to two
            number /=2;
        }else if(command === 'dice'){
            number = Math.sqrt(number);
        }else if(command === 'spice'){
            number +=1;
        }else if(command === 'bake'){
            number *=3;
        }else if(command === 'fillet'){
            number =number - (number * 0.20);
        }
        console.log(number);
    }
}