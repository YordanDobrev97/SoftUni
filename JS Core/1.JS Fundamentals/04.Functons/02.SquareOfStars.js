function printSquareStars(number = 5){
    function print(count = number){
        console.log("*" + " *".repeat(count-1));
    }
    for(let i = 1; i<=number; i++){
       print();
    }
}