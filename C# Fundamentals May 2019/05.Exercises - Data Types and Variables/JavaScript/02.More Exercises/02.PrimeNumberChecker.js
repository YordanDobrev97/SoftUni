function isPrime(number) {
    let isPrime = true;
    let sqr = Math.sqrt(number);

    for (let i = 2; i <=sqr; i++) {
        if (number % i === 0){
            isPrime = false;
            break;
        }
    }

    return isPrime && (number > 1);
}
console.log(isPrime(81));