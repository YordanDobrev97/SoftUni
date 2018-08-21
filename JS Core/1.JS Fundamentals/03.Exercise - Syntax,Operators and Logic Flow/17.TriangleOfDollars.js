function printTriangleOfDollars(number){
    let result = '';
    for(let i = 1; i <=number; i++){
        for(let j = 1; j <=i; j++){
            result +='$';
        }
        result +='\n';
    }
    console.log(result);
}