function printElementWithStep(array){
    let step = Number(array[array.length - 1]);

    for(let i = 0; i < array.length - 1; i+=step){
        console.log(array[i]);
    }
}