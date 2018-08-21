function countWords(string, symbolOfString){
    let counter = 0;
    for(let item of string){
        if(item === symbolOfString)
        counter++;
    }
    console.log(counter);
}
