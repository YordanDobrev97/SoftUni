function arithmephile(input){
    let numbers = [];

    parseNumbers(input);
    
    for(let number of numbers)
    {
        if(number >= 0 && number < 10){
            
        }
    }


    function parseNumbers(inputArray){
        for(let item of inputArray)
        {
            let num = +item;
            numbers.push(num);
        }
    }

}
arithmephile(['10','20','2','30','44','3','56','20','24']);