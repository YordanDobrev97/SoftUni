class Vehicle {
    constructor(type, model, parts, fuel){
        this.type = type;
        this.model = model;
        this.parts = parts;
        this.setQuantity();
        this.fuel = fuel;
    }

    drive(fuelDecreasing) {
        this.fuel -= fuelDecreasing;
    }
    setQuantity() {
        let engine = this.parts['engine'];
        let power = this.parts['power'];
        let totalQuantity = Number(engine) * Number(power);
        this.parts.quantity = totalQuantity;
    }
}

let parts = {engine: 6, power: 100};
let vehicle = new Vehicle('a', 'b', parts, 200);
vehicle.drive(100);
console.log(vehicle.fuel);
console.log(vehicle.parts.quantity);

