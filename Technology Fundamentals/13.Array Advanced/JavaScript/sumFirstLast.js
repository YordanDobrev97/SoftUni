function sumFirstLast(array){
    let first = array.shift();
    let last = array.pop();

    let sum = Number(first) + Number(last);

    console.log(sum);
    
}
sumFirstLast(['1', '2','3','4'])