function convertObjectToJson(input) {
  const regexText =/ ([A-Za-z\s\??])+/;
  const regexValues = /(-?\d+\.\d+)/g;
  input.shift();

  const result = [];
  for (let item of input) {
    let obj = item;
    let execute = regexText.exec(obj);
    let key = execute[0].trim();
    
    let values =  item.match(regexValues).map(Number);
    let latitude = Number(values[0].toFixed(2));
    let longitude = Number(values[1].toFixed(2));

    let newObj = {
      Town: key,
      Latitude: latitude,
      Longitude: longitude
    };
    
    result.push(JSON.stringify(newObj))
  }
  console.log(`[${result.join(',')}]`);
}

convertObjectToJson([
  "| Town | Latitude | Longitude",
  "| Sofia | -42.696552 | 23.32601",
  "| Beijing | 39.913818 | 116.363625"
]);
