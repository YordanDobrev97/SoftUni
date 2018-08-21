function countOccurrences(findWord, text){
    let counter = 0;
    let index = text.indexOf(findWord);
    while(index !== -1){
        index++;
        index = text.indexOf(findWord, index);
        counter++;
    }
    console.log(counter);
}