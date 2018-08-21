function negativePositiveNums(array){
    let resultArray = [];
    for(let i = 0; i< array.length; i++){
        let element = array[i];
        if(element < 0){
            resultArray.unshift(element);
        }else{
            resultArray.push(element);
        }
    }
    for(let item of resultArray){
        console.log(item);
    }
}