function printName(callback) {
    callback('Pesho', 'Gosho');
}

function names(firstName, secondName) {
    console.log(`I am firstName: ${firstName}`);
    console.log(`I am secondName: ${secondName}`);
}

printName(names);