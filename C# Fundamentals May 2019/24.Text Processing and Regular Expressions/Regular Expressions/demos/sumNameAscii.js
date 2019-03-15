function sumNameAscii(input){
    let pattern = '[a-z]+\b';

    for(let item of input)
    {
        let matchFirstName = item.match(pattern);
        let matchLastName = item.match(pattern);
    }

}
sumNameAscii(['pesho ivanov','petur petrov','ivan ivanov','geogri georgiev', 'gOShO', '99313441kd2'])