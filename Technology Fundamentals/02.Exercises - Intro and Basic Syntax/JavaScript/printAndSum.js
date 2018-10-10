function solve(startNumber, endNumber){
    let range = [];
    let sum = 0;
    for(let i = startNumber; i <= endNumber; i++){
        range.push(i);
        sum +=i;
    }

    let output = "";
    for(let i = 0; i < range.length; i++){
        output += range[i] + " ";
    }

    console.log(output);
    console.log(`Sum: ${sum}`);
}
solve(5,10);
solve(50,60);