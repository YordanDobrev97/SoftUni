function convertToObject(jsonString) {
    let parseJsonString = JSON.parse(jsonString);

    let entries = Object.entries(parseJsonString);

    for(let [key, value] of entries) {
        console.log(`${key}: ${value}`);
    }
}
convertToObject('{"name": "George", "age": 40, "town": "Sofia"}')