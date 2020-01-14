function extractIncreasingElements(array) {
    let result = [];
    let prevElement = array[0];

    result.push(prevElement);
    for (let i = 1; i < array.length; i++){
        const element = array[i];
        
        if (prevElement <= element) {
            prevElement = element;
            result.push(element);
        }
    }

    console.log(result.join('\n'));
}