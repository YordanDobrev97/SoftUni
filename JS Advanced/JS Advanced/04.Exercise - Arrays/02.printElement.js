function printWithStep(array) {
    let step = Number(array.pop());

    for (let i = 0; i < array.length; i+= step) {
        let element = array[i];
        console.log(element);
    }
}
printWithStep([
  '5', '20', '31', '4', '20', '2'
]);
