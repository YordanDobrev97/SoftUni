function solve(obj){
    let handsShaking = obj.handsShaking;
    if(handsShaking){
        //calc blood alcohol level
        let getWeight = obj.weight;
        let quantity = obj.bloodAlcoholLevel;
        let experience = obj.experience;
        let sum = (getWeight * 0.1 * experience) + quantity;
        obj.handsShaking = false;
        obj.bloodAlcoholLevel = sum;
        //console.log(sum);
    }
    return{
        weight: obj.weight,
        experience: obj.experience,
        bloodAlcoholLevel: obj.bloodAlcoholLevel,
        handsShaking: obj.handsShaking
    };
}
console.log(solve({ weight: 120,experience: 20,bloodAlcoholLevel: 200,handsShaking: true }));
console.log(solve({ weight: 80,experience: 1,bloodAlcoholLevel: 0,handsShaking: true }));
console.log(solve({ weight: 95,experience: 3,bloodAlcoholLevel: 0,handsShaking: false}));