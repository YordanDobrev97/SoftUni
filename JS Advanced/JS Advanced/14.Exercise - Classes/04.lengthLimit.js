class Stringer {
    constructor(innerString, innerLength) {
        this.innerString = innerString;
        this.innerLength = innerLength;
    }

    increase(length) {
        this.innerLength += length;

        if (this.innerLength < 3) {
            this.innerLength = 0;
        }
    }

    decrease(length) {
        this.innerLength -= length;

        if (this.innerLength < 3) {
            this.innerLength = 0;
        }
    }

    toString() {
        if (this.innerLength === 0) {
            return '...';
        }
        if (this.innerString.length > this.innerLength) {
            return this.innerString.substring(0, this.innerLength) + '...';
        }
        return this.innerString.substring(0, this.innerLength);
    }
}

let test = new Stringer("Viktor", 6);
console.log(test.toString());

