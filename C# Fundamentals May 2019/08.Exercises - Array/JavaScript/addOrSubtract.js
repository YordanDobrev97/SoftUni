function addOrSubtract(array){

    let sum = array.reduce((a, b) => a + b, 0);
    for (let index = 0; index < array.length; index++) {
        let element = array[index];
        
        if(element % 2 == 0){
            array[index] = element + index;
        }else{
            array[index] = element - index;
        }
    }
    let newSum = array.reduce((a, b) => a + b, 0);
    console.log('[ ' + array.join(', ') + ' ]');
    console.log(sum);
    console.log(newSum);
}
addOrSubtract([5,15,23,56,35]);