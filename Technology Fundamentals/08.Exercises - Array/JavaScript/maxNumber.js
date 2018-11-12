function maxNumbers(array){
    let maxNumbers = [];
    let maxNumber = array.splice(-1,1);

    for (let index = 0; index < array.length; index++) {
        const element = array[index];
        
        if(element > maxNumber && !(maxNumbers.includes(element))){
            maxNumbers.push(element);
        }
    }

    maxNumbers.push(maxNumber);
    console.log(maxNumbers.join(' '));
}
maxNumbers([41, 41 ,34, 20]);
maxNumbers([1, 4, 3, 2]);
maxNumbers([14, 24, 3, 19, 15, 17]);
maxNumbers([27, 19, 42, 2, 13, 45, 48]);
maxNumbers([-10,-1,5]);
