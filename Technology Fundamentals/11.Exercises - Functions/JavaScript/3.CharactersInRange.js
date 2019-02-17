function solve(start, end){
    let alhabets = [
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
        'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    ];

    let startIndex = alhabets.indexOf(start);
    let endIndex = alhabets.indexOf(end);

    let result = [];
    for (let i = startIndex + 1; i < endIndex; i++) {
        result.push(alhabets[i]);
    }
    
    console.log(result.join(' '));
    //console.log(elements);
}
//solve('a', 'd');
solve('#',':');