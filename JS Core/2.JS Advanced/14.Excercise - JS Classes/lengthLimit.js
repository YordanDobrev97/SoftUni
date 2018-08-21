class Stringer{
    constructor(singleStr, length){
        this.singleStr = singleStr;
        this.length = length;
    }
    increase(increaseLength){
        this.length +=increaseLength;
    }
    decrease(decreaseLength){
        this.length -=decreaseLength;
        if(this.length < 0){
            this.length = 0;
        }
    }
    toString(){
        if(this.length < this.singleStr.length){
            return `${this.singleStr.slice(0, this.length)}...`;
        }
        return `${this.singleStr.slice(0, this.length)}`;
    }
}
let test = new Stringer("Test", 5);
console.log(test.toString()); //Test
test.decrease(3);
console.log(test.toString()); //Te...

test.decrease(5);
console.log(test.toString()); //...

test.increase(4);
console.log(test.toString()); //Test

