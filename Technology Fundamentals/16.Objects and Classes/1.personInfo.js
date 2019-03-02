function personInfo(firstName, lastName, age) {
    let person = {firstName: firstName, lastName: lastName, age: age};

    for(let item in person) {
        console.log(`${item}: ${person[item]}`);
    }
}
personInfo('pesho', 'peshov', 10);