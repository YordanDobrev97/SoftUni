function addAndRemoveItems(array){
    let arr = [];

    let number = 1;
    for(let i = 0; i < array.length; i++){
        let command = array[i];
        if(command === 'add'){
            arr.push(number);
        }else{
            arr.pop();
        }
        number++;
    }
    if(arr.length === 0){
        console.log("Empty");
    }else{
        console.log(arr.join("\n",));
    }
}