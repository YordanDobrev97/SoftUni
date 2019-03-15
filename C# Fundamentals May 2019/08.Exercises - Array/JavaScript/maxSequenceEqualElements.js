function maxSequenceEqualElements(input){
    let array = input[0].split(' ');

    let currentCount = 1;
    let maxCount = 1;
    let value = '';

    let currentElement = '';
    for (let index = 0; index < array.length - 1; index++) {
        currentElement = array[index];
        let nextElement = array[index + 1];

        if(currentElement == nextElement){
            currentCount++;
        }else{
            if(currentCount > maxCount){
                maxCount = currentCount;
                value = currentElement;
            }
            currentCount = 1;
        }
    }
    
    if(currentCount > maxCount){
        maxCount = currentCount;
        value = currentElement;
    }
    
    let output = '';
    for (let index = 0; index < maxCount; index++) {
        output += `${value} `;
    }

    console.log(output);
}
//maxSequenceEqualElements(["4 4 4 4"]);
maxSequenceEqualElements(["2 1 1 2 3 3 2 2 2 1"]);
//maxSequenceEqualElements([1,1,1,2,3,1,3,3]);