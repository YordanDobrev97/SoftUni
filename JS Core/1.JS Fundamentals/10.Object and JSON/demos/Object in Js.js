let obj = { name : "SoftUni", age : 3 };
console.log(obj); // Object {name: "SoftUni", age: 3}
obj['site'] = "https://softuni.bg";
obj.age = 10;
obj["name"] = "Software University";
console.log(obj); // Object {name: "Software University", age: 10, site: "https://softuni.bg"}
delete obj.name; // Delete a property
obj.site = undefined; // Delete a property value
console.log(obj); // Object {age: 10, site: undefined}