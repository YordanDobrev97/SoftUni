class CheckingAccount {
    constructor(clientId, email, firstName, lastName) {
        this.isFirst = -1;
        this.validateClientId(clientId);
        this.validateEmail(email);
        this.validateName(firstName, lastName);
        
    }

    validateClientId(value) {
        if (value.length !== 6) {
            throw TypeError('Client ID must be a 6-digit number');
        }
        this.clientId = value;
    }
    
    validateEmail(value) {
        const regex = /[a-z]{1,}@[a-z]{1,}\w.+/gm;
        if (!regex.test(value)) {
            throw TypeError('Invalid e-mail');
        }
        this.email = value;
    }
    
    validateName(firstName, lastName) {
        if (!this.isRangeLength(firstName) || !this.isRangeLength(lastName)) {
            let name = this.isFirst === 0 ? 'First': 'Last';
            throw new TypeError(`${name} name must be between 3 and 20 characters long`);
        }

        this.isFirst = -1;

        if (!this.isValidName(firstName) || ! this.isValidName(lastName)) {
            let name = this.isFirst === 0 ? 'First': 'Last';
            throw new TypeError(`${name} name must contain only Latin characters`);
        }

        this.firstName = firstName;
        this.lastName = lastName;
    }

    isRangeLength(name) {
        this.isFirst++;
        if (!(name.length >= 3 && name.length <= 20)) {
            return false;
        }
        return true;
    }

    isValidName(name) {
        const regexName =/^[A-Za-z]+$/gm;
        this.isFirst++;
        return regexName.test(name);
    }
}
let acc = new CheckingAccount('423414', 'petkan@another.co.uk', 'Petkan', 'D');
console.log(acc);