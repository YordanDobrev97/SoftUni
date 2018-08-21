class Person{
    constructor(name){
        this.name = name;
    }
    toString(){
        return `I am ${this.name}`
    }
}
let pesho = new Person('Pesho');
console.log(pesho.toString());

