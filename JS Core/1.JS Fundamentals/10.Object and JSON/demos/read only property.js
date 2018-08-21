//'use strict';
let cat = { name: 'Tom', age: 5 };
Object.freeze(cat);
cat.age = 10;	   // Error in strict mode
cat.gender = 'male';  // Error in strict mode
console.log(cat);     // { name: 'Tom', age: 5 }
