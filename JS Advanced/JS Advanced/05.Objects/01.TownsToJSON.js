function convertObjectToJson(input) {
    
    let jsonElements = [];
    let keys = input.shift().split('|');
    keys = keys.filter(function(str) {
        str = str.trim();
        return /\S/.test(str);
    });

    console.log('object');

    function createObject() {}

    function convertObjectToJson() {}

    
}

convertObjectToJson(
    ['| Town | Latitude | Longitude',
     '| Sofia | 42.696552 | 23.32601',
     '| Beijing | 39.913818 | 116.363625']);