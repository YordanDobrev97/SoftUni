class Rectangle {
    constructor(width, height, color){
        this.width = width;
        this.height = height;
        this.color = color;
    }
    calcArea() {
        return this.width * this.height;
     }
}
let rectangle = new Rectangle(4,5,'red');
console.log(rectangle.width);
console.log(rectangle.height);
console.log(rectangle.color);
console.log(rectangle.calcArea());