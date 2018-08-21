function assignProperties(items){
    let firstKey = items[0];
    let valueOfFirstKey = items[1];

    let secondKey = items[2];
    let valueOfSecondKey = items[3];

    let thirdKey = items[4];
    let valueOfThirdKey = items[5];

    return JSON.parse(`{ "${firstKey}": "${valueOfFirstKey}", "${secondKey}": "${valueOfSecondKey}", "${thirdKey}": "${valueOfThirdKey}" }`);
}