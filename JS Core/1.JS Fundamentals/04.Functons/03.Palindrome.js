function palidrome(text){
    let string = text + '';
    let isPalidrom = false;
    for(let i = 0; i < string.length; i++){
        let first = string[i];
        let last = string[string.length - i - 1];

        if(first === last){
            isPalidrom = true;
        }else{
            isPalidrom = false;
            break;
        }
    }
    console.log(isPalidrom);
}