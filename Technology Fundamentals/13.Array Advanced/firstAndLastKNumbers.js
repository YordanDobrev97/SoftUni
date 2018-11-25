function firstLastKNums(array){
    let k = array.shift();
    
    let firstElements = array.slice(0,k);
    let lastElements = array.slice(array.length - k);

    console.log(firstElements.join(' '));
    console.log(lastElements.join(' '));
    
}
firstLastKNums([2,7,8,9]);