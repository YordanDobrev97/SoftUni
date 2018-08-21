let obj = { name : "SoftUni", age : 3 };
let str = JSON.stringify(obj);
console.log(str); // {"name":"SoftUni","age":3}

let str = "{\"name\":\"Nakov\",\"age\":24}"
let obj = JSON.parse(str);
console.log(obj); // Object {name: "Nakov", age: 24}
