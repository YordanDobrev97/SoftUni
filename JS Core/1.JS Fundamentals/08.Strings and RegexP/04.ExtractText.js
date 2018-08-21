function extractText(text){
    let result = [];
    let startIndex = text.indexOf('(');
    let endIndex = text.indexOf(')', startIndex);
    while(startIndex < endIndex){
        result.push(text.substring(startIndex+1, endIndex));
        text = text.substr(endIndex +1);
    
        startIndex = text.indexOf('(');
        endIndex = text.indexOf(')');
    }
    console.log(result.join(', '));
}