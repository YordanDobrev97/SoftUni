function solve(input){
    let userName = input[0];
    input.shift();
    let password = userName.split("").reverse().join("");
    //input.pop();
    let wrongCounter = 1;
    for(let i = 0; i < input.length; i++){
        let value = input[i];
        if(value == password){
            console.log(`User ${userName} logged in.`);
            break;
        }else{
            console.log('Incorrect password. Try again.');
            wrongCounter++;
        }
        if(wrongCounter >=4){
            console.log(`User ${userName} blocked!`);
            break;
        }  
    }
}
//solve(['Acer', 'login', 'go', 'let me in', 'recA']);
solve(['sunny','rainy','cloudy','sunny','notsunny']);