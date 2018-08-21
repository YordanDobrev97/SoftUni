// access keys
let course = { name: 'JS Core', hall: 'Open Source' };
let keys = Object.keys(course); 
console.log(keys);  // [ 'name', 'hall' ]
if (course.hasOwnProperty('name')){
    console.log(course.name);  // JS Core 
}

// access values
let values = Object.values(course); 
console.log(values); // [ 'JS Core', 'Open Source' ]
if (values.includes('JS Core')){
    console.log("Found 'JS Core' value");
}
    
