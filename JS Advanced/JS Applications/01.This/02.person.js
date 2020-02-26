class Person {
    constructor(firstName, secondName) {
        this.firstName = firstName;
        this.lastName = secondName;
    }

    get fullName() {
        return `${this.firstName} ${this.lastName}`;
    }

    get firstName() {
        return this._firstName;
    }

    get lastName() {
        return this._lastName;
    }

    set firstName(value) {
       this._firstName = value;
    }

    set lastName(value) {
        this._lastName = value;
    }

    set fullName(newValue) {
        const [first, last] = newValue.split(' ');

        if (first && last) {
            this._firstName = first;
            this._lastName = last;
        }
        return `${ this.firstName} ${ this.lastName}`;
    }
}

let person = new Person("Peter", "Ivanov");
console.log(person.fullName);//Peter Ivanov
person.firstName = "George";
console.log(person.fullName);//George Ivanov
person.lastName = "Peterson";
console.log(person.fullName);//George Peterson
person.fullName = "Nikola Tesla";
console.log(person.firstName)//Nikola
console.log(person.lastName)//Tesla
