function solve(input) {
    const regex = /[\s+\'\.\-,]/gm;
    let elements = input[0].split(regex).filter(x => x != '');

    let obj = {};
    for(let item of elements) {
        if (!obj.hasOwnProperty(item)) {
            obj[item] = 0;
        }
        obj[item] += 1;
    }

    return JSON.stringify(obj);
}

console.log(solve(['Far too slow, you\'re far too slow.']));