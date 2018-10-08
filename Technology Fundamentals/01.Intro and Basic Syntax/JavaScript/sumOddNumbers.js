function sumOddNums(number){
    let sum = 0;
    let num = 1;

    let count = 1;
    while (count <= number){
        if (num % 2 == 1){
            sum += num;
            console.log(num);
            num+=2;
        }
        count++;
    }
    console.log(`Sum: ${sum}`);
}
sumOddNums(5);