function solve(number){
    for (let i = 97; i < 97 + number; i++) {
        for (let second = 97; second < 97 + number; second++) {
           for (let third = 97; third < 97 + number; third++) {
                console.log(`${String.fromCharCode(i)}${String.fromCharCode(second)}${String.fromCharCode(third)}`);   
           }   
        }
    }
}
solve(3);