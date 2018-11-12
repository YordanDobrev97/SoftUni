function condenseArray(array){

    while(array.length > 1){
        for (let index = 0; index < array.length - 1; index++) {
            let currentElement = array[index];
            let nextElement = array[index + 1];

            let sum = currentElement + nextElement;
            array[index] = sum;
        }
        array.length--;
    }
    console.log(array[0]);
}
condenseArray([2,10,3]);
condenseArray([5,0,4,1,2]);