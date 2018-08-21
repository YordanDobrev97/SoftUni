class Person{
    constructor(name, email){
        this.name = name;
        this.email = email;
    }
    toString(){
        return `Name: ${this.name} Email: ${this.email}`;
    }
}
class Teacher extends Person{
    constructor(name,email,subject){
        super(name,email);
        this.subject = subject;
    }
    toString(){
        return `Name: ${this.name} Email: ${this.email} Subject: ${this.subject}`;
    }
}
let person = new Person('Misho', 'misho@gmail.com');
console.log(person);
let teacher = new Teacher('Pesho', 'pesho@abv.bg', 'JS Core');
console.log(teacher);
