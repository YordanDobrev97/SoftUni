function searchNumber(firstArray,secondArray){
    let takeElements = secondArray.shift();
    let deleteElementsCount = secondArray.shift();
    let searchNumber = secondArray.shift();
    let elements = [];

    for(let i = 0; i < takeElements; i++){
        elements.push(firstArray[i]);
    }

    for(let i = 0; i < deleteElementsCount; i++){
        elements.pop();
    }

    if(elements.includes(searchNumber)){
        let count = 0;
        for(let i = 0; i < elements.length; i++){
            if(elements[i] == searchNumber){
                count++;
            }
        }
        console.log(`Number ${searchNumber} occurs ${count} time.`);
    }
}
searchNumber([5, 2, 3, 4, 1, 6],[5, 2, 3])