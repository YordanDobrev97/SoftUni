function towsJSON(array){
    let result = [];
    array.shift();
    for(let i = 0; i<array.length;i++) {
        let element = array[i].split(/\s*\|\s*/)
        .filter(el => el !== '');
        let obj = {'Town': element[0],
        'Latitude':element[1], 'Longitude':element[2]};
        result.push(obj);
    }
    console.log(JSON.stringify(result));
}
towsJSON(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']);

towsJSON(['| Town | Latitude | Longitude |',
'| Veliko Turnovo | 43.0757 | 25.6172 |',
'| Monatevideo | 34.50 | 56.11 |']);