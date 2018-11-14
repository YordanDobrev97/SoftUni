function solve(powerKW) {
    powerKW = Number(powerKW);

    let power = calculate(powerKW);
    console.log(`${power.toFixed(2)} lv.`);

    function calculate(powerKW){
        if(powerKW < 37){
            return powerKW * 0.43;
        }else if(powerKW > 37.01 && powerKW <55){
            return powerKW * 0.50;
        }else if(powerKW > 55.01 && powerKW < 74.00){
            return powerKW * 0.68;
        }else if(powerKW > 74.01 && powerKW < 110){
            return powerKW * 1.38;
        }else{
            return powerKW * 1.54;
        }
    }
}
solve(57.50);