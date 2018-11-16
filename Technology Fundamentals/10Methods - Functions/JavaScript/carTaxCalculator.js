function solve(powerKW, age) {
    powerKW = Number(powerKW);
    age = Number(age);

    let power = calculateTax(powerKW);
    let result = calculateCoefficient(age, power);

    console.log(`${result.toFixed(2)} lv.`);

    function calculateCoefficient(age, result){
        if(age < 5){
            result *= 2.80;
        }else if(age < 14){
            result *=1.50;
        }else{
            result *= 1.00;
        }
        return result;
    }
    function calculateTax(powerKW){
        if(powerKW <=37){
            return powerKW * 0.43;
        }else if(powerKW <=55){
            return powerKW * 0.50;
        }else if(powerKW <=74.00){
            return powerKW * 0.68;
        }else if(powerKW <=110){
            return powerKW * 1.38;
        }else{
            return powerKW * 1.54;
        }
    }
}
