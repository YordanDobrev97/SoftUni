class Circle {
    constructor(radius){
        this.radius = radius;
    }
    get diameter(){
        return this.radius * 2;
    }
    set diameter(newDiameter){
        this.radius = newDiameter / 2;
    }
    get calcArea(){
        return Math.PI * this.radius * this.radius;
    }
}
let c = new Circle(2);
console.log(`Radius ${c.radius}`);
console.log(`Diameter ${c.diameter}`);
console.log(`Area ${c.calcArea}`);
c.diameter = 1.6;
console.log(`Diameter: ${c.diameter}`);