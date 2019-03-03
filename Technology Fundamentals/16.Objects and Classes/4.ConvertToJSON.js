function convertToJson(firstName, lastName, hairColor) {
    let person = {
        name: firstName, 
        lastName: lastName, 
        hairColor: hairColor
    };

    let convertToObjToJson = JSON.stringify(person);
    console.log(convertToObjToJson);
}
convertToJson('Pesho', 'Ivanov', 'white');