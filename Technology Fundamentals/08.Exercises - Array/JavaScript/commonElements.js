function commonElements(firstArray, secondArray){
    let commonElements = [];

    for (let index = 0; index < firstArray.length; index++) {
        const element = firstArray[index];
        
        let count = 0;
        for (let secondIndex = 0; secondIndex < secondArray.length; secondIndex++) {
            const nextElement = secondArray[secondIndex];
            
            if(element === nextElement){
                count++;
            }
        }
        if(count > 0){
            commonElements.push(firstArray[index]);
        }
    }
    for(let item of commonElements)
    {
        console.log(item);
    }
}
commonElements(['Hey', 'hello', 2, 4, 'Pesho', 'e'],
['Pecho', 10, 'hey', 4,'hello', '2'])