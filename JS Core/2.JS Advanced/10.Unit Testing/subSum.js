function subSum(array, start, end){
    if(!Array.isArray(array)){
        return NaN;
    }
    let sum = 0;
    if(start < 0){
        start = 0;
    }
    if(array.length === 0){
        return 0;
    }
    if(end > array.length){
        end = array.length - 1;
    }
    array = array.slice(start, end + 1);
    for(let i = start; i<=end;i++) {
        if(array[i] !== Number(array[i])){
            return NaN;
        }
        sum +=array[i];
    }
    console.log(sum);
}
console.log(subSum(('text', 0, 2)));