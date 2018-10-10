function solve(number){
    let output = "";
    for(let row = 1; row <= number; row++){
        for(let col = 1; col <= row; col++){
            output += row + " ";
        }
        output += "\n";
    }
    console.log(output);
}
solve(5);