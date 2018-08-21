function solve(objCar){
    let model = objCar.model;
    let power = objCar.power;
    let color = objCar.color;
    let carriage = objCar.carriage;
    let wheelSize = objCar.wheelsize;

    let result = {
        model:objCar.model
    }
    if(power <= 90){
       result.engine = {
           power:90,
           volume: 1800
       }
    }else if(power <=120){
        result.engine = {
            power: 120,
            volume: 2400
        }
    }else{
        result.engine = {
            power: 200,
            volume: 3500
        }
    }
    result.carriage = {
        type:carriage,
        color:color
    }
    let value = wheelSize;
    if(wheelSize % 2 == 0){
        value -=1;
    }
    result.wheels = [value,value,value,value];

    return result;
}
console.log(solve({ model: 'VW Golf II',power: 90,color: 'blue',carriage: 'hatchback',wheelsize: 14 }));