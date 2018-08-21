class CheckingAccount{
    constructor(clientId,email,firstName,lastName ){
        this.clientId = clientId;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
    }
    set clientId(id){
        let regex =  /^\d{6}$/;
        if(!regex.test(id)){
            throw new TypeError('Client ID must be a 6-digit number');
        }
        return id;
    }
    set email(email){
        let regex = /^[A-Za-z]+@[A-Za-z\.]+$/;
        if(!regex.test(email)){
            throw new TypeError('Invalid e-mail');
        }
        return email;
    }
    set firstName(firstName){
        if(firstName.length < 3 || firstName.length > 20){
            throw new TypeError('"First name must be between 3 and 20 characters long');
        }
        let regex =  /^[A-Za-z]+$/;
        if(!regex.test(firstName)){
            throw new TypeError('First name must contain only Latin characters');
        }
        return firstName;
    }
    set lastName(lastName){
        if(lastName.length < 3 || lastName.length > 20){
            throw new TypeError('"Last name must be between 3 and 20 characters long');
        }
        let regex =  /^[A-Za-z]+$/;
        if(!regex.test(lastName)){
            throw new TypeError('Last name must contain only Latin characters');
        }
        return lastName;
    }
}
//let acc = new CheckingAccount('1314', 'ivan@some.com', 'Ivan', 'Petrov');
//let acc = new CheckingAccount('131455', 'ivan@', 'Ivan', 'Petrov');
//let acc = new CheckingAccount('131455', 'ivan@some.com', 'I', 'Petrov')
//let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')
let acc = new CheckingAccount('123456', 'Ivan@Ivanov.bg', 'Ivan', 'Ivanov');
console.log(acc);