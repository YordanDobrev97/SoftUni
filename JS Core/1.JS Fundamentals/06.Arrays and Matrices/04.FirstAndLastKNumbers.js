function firstLastKItems(array){
    let k = array.shift();

    let firstKElements = array.slice(0, k);
    let secondKElements = array.slice(array.length - k, array.length);
    console.log(firstKElements);
    console.log(secondKElements);
}