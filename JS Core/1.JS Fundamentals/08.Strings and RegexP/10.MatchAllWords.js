function matchWords(text){
    let match = text.match(/\w+/g);
    console.log(match.join('|'));
}