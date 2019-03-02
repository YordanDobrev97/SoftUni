function cityObject(name, area, population, country, postCode) {
    let cityObj = {name: name, area: area, population: population, country: country, postCode: postCode};

    let entries = Object.entries(cityObj);

    for(let [key, value] of entries) {
        console.log(`${key} -> ${value}`);
    }
}
cityObject("Sofia"," 492", "1238438", "Bulgaria", "1000");