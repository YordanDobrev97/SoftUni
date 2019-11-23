function convertToUpperCase(input) {
    input = input.replace(/(\.|,|\?|!|\ )/gm, ' ');
    let items = input.split(/\s+/);
    items = items.filter(el => el != '');

    let join = items.join(', ');
    let upper = join.toUpperCase();
    return upper;
}

console.log(convertToUpperCase('Hi, how are you?'));