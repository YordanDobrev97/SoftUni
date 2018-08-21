function imperiaUnits(inches){
    let inchesFeet = 12;
    let feet = Math.floor(inches / inchesFeet);
    let inch = inches % inchesFeet;

    console.log(`${feet}'-${inch}"`);
}