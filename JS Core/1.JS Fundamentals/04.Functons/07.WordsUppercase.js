function upperCaseWords(words){
    let upper = words + '';
    upper = upper.toUpperCase();
    let wordsExctract = extract();
    wordsExctract = wordsExctract.filter(w => w != '');
    return wordsExctract.join(', ');

    function extract(){
        return upper.split(/\W+/);
    }
}