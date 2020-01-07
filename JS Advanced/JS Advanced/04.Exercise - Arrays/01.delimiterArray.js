function printWithDelimiter(array) {
    let delimiter = array.pop();
    let result = array.join(delimiter);
    console.log(result);
}
printWithDelimiter([
  'One', 'Two', 'Three', 'Four', 'Five', '-'
]);
