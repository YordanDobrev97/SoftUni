function filterEmployees(input, filterCriteria) {
    let array = JSON.parse(input);
    let result = [];
    let [property, value] = filterCriteria.split('-');
    for(let item of array) {
        let valueProperty = item[property];
        if (valueProperty === value) {
            result.push(`${item.first_name} ${item.last_name} - ${item.email}`);
        }
    }

    let counter = 0;
    for(let item of result) {
        console.log(`${counter++}. ${item}`);
    }
}