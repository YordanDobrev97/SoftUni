class Figure{
    constructor(){
        if(this.constructor.name === 'Figure'){
            throw new Error('Cannot create an instance of the abstract class');
        }
    }
}
class Circle extends Figure{
    constructor(radius){
        super();
        this.radius = radius;
    }
    area(){
        return Math.PI * this.radius * this.radius;
    }
    toString(){
        return `${this.constructor.name} - radius: ${this.radius}`;
    }
}
class Rectangle extends Figure{
    constructor(width, height){
        super();
        this.width = width;
        this.height = height;
    }
    area(){
        return this.width * this.height;
    }
    toString(){
        return `${this.constructor.name} width: ${this.width}, height: ${this.height}`
    }
}
//let f = new Figure();
let c = new Circle(5);
console.log(c.area);        //78.53981633974483
console.log(c.toString());  //Circle - radius: 5
let r = new Rectangle(3,4);
console.log(r.area);        //12
console.log(r.toString());  //Rectangle - width: 3, height: 4
