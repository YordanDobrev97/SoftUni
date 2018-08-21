function sumFirstLastElement(array){
    let firstElement = array[0];
    let lastElement = array[array.length - 1];

    let sum = Number(firstElement) + Number(lastElement);
    console.log(sum);
}