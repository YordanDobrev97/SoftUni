function concatNames(firstName, lastName, delimiter){
    let concat = `${firstName}${delimiter}${lastName}`;
    return concat;
}
console.log(concatNames('John','Smith','->'));
console.log(concatNames('Jan','White','<->'));
