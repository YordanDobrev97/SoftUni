function aggregates(array) {
    let sum = array.reduce((a, b) => a + b);
    console.log("Sum = " + sum);

    let min = array.reduce((a, b) => Math.min(a,b));
    console.log("Min = " + min);

    let max = array.reduce((a, b) => Math.max(a,b));
    console.log("Max = " + max);
    
    let product = array.reduce((a, b) => a * b);
    console.log("Product = " + product);

    let join = array.join('');
    console.log("Join = " + join);
}
aggregates([2,3,10,5]);