function isPrime(number){
    let isPrimeNumber = true;
    if(number < 2){
        isPrimeNumber = false;
    }else{
        for(let i = 2; i <=number - 1; i++){
           if(number % i == 0){
                isPrimeNumber = false;
                break;
            }
        }   
    }
    console.log(isPrimeNumber);
}