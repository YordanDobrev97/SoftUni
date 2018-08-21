function printStars(counter){
    let result = '';
    for(let i = 1; i <=counter; i++){
        for(let j = 1; j <=i; j++){
           result +='*';
        }
        result +='\n';
    }
    //console.log(result);
    
    let count = counter - 1;

    for(let j = 1; j<=counter;j++){
        for(let i = 1; i<=count; i++){
          result +='*';
        }  
        result +='\n';
        count--;
    }

    console.log(result);
}

function otherSolve(number){
    for(let i = 1; i<=number; i++){
        console.log("*".repeat(i));
    }
    for(let i = number -1; i>=1; i--){
        console.log("*".repeat(i));
    }

}