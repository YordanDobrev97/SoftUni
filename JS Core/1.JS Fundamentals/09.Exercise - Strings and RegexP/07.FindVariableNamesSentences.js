function findVariable(str){
    let result = [];
    let regex =/\b_[a-zA-Z]+\b/g;
    let match = regex.exec(str);
    while (match) {
        result.push(match[1]);
        match = regex.exec(str);
    }
    console.log(result.join(','));
}