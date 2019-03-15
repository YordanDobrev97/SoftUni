function magicSum(input){
    let array = input[0].split(' '); // split string
    let uniquePairs = [];
    let sum = Number(input.splice(-1,1)); // remove last element

    for (let index = 0; index < array.length - 1; index++) {
        let currentElement = Number(array[index]);

        foundPairs(currentElement, index);//I'm looking for couples
    }

    function foundPairs(currentElement, currentIndex){

        for (let index = 0; index < array.length; index++) {
            let element = Number(array[index]);
            let currentSum = element + currentElement;

            if(currentSum === sum 
                && index !== currentIndex
                &&(!uniquePairs.includes(currentElement) 
                &&(!uniquePairs.includes(element)))){

                uniquePairs.push(currentElement);
                uniquePairs.push(element);
                break;
            }
            
        }
    }

    //print all unique pairs
    for (let index = 0; index < uniquePairs.length; index+=2) {
       let currentElement = uniquePairs[index];
       let nextElement = uniquePairs[index + 1];

       console.log(`${currentElement} ${nextElement}`);
    }
}
//
magicSum(['1 2 3 4 5 6' ,'6']);
magicSum(['14 20 60 13 7 19 8', '27']);
magicSum(['1 7 6 2 19 23','8']);
