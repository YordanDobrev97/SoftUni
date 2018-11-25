function negativePositiveNumbers(array){
    let result = [];

    for (let index = 0; index < array.length; index++) {
        let element = array[index];
        
        if(element < 0){
            result.unshift(element);
        }else{
            result.push(element);
        }
    }

    for(let item of result)
    {
        console.log(item);
    }
}
negativePositiveNumbers([-3,2,-1,0]);