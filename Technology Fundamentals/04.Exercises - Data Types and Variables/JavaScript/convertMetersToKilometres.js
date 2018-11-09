function convertMetersInKillometers(meters){
    let cursor = 0.001;

    let killometers = meters * cursor;

    console.log(killometers.toFixed(2));
}
convertMetersInKillometers(1852);