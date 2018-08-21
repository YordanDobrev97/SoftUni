let map = new Map();
map.set(3,"Pesho");
map.set(1,"Gosho");
map.set(7,"Aleks");

let sort =new Map([...map.entries()].sort());
let result = 'Map { ';
for(let item of sort)
{
    let key = item[0];
    let value = item[1];
    result +=`${key} => '${value}' `;
}
result +='}'
console.log(result);

