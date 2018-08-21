function personalBmi(name, age, weight, height){
    let calcBmi = 
    Math.round(weight / Math.pow(height / 100, 2));
    
    let statusValue = '';
    if(calcBmi < 18.5){
        statusValue = 'underweight';
    }else if(calcBmi < 25){
        statusValue = 'normal';
    }else if(calcBmi < 30){
        statusValue = 'overweight';
    }else{
        statusValue = 'obese';
    }

    let patient = {
        name: name,
        personalInfo: {
            age: age,
            weight: weight,
            height: height
        },
        BMI: calcBmi,
        status: statusValue
    }
    if(statusValue === 'obese'){
        patient['recommendation'] = 'admission required';
    }
    return patient;
}
console.log(personalBmi('Peter', 29,75,182));