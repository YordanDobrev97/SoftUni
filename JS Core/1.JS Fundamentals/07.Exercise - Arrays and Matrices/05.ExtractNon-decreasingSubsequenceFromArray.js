function nonDecreasingSubsequence(array){
    let start = array[0];
    let arr = [start];
    for(let i = 1; i< array.length; i++){
        let currentElement = array[i];
        if(start <=currentElement){
            arr.push(currentElement);
            start = currentElement;
        }
    }
    console.log(arr.join('\n'));
}