function aggregateTable(array) {
    let towns = [];
    let totalValue = 0;
    for (let item of array) {
        let elements = item + "".split("|");
        let startIndex = elements.indexOf("|");
        let endIndex = elements.indexOf("|", startIndex + 1);
        let valueTown = elements.substring(endIndex + 1).trim();
        totalValue +=Number(valueTown);
        let subStr = elements.substring(startIndex + 1, endIndex).trim();
        towns.push(subStr);
    }
    console.log(towns.join(", "));
    console.log(totalValue);
}