function findOccurrencesWord(text, target){
    let pattern = new RegExp(`\\b${target}\\b`, 'gi');
    let match = text.match(pattern);
    console.log(match === null ? 0 : match.length);
}