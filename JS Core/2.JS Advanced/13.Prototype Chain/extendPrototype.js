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
function extendClass(ClassExtended){
    ClassExtended.prototype.species = 'Human';
    ClassExtended.toSpeciesString = function(){
        return `I am a ${this.species}. ${this.toString()}`;
    }
}
extendClass(Person);