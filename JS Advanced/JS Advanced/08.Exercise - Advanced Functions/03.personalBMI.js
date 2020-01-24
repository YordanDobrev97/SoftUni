const solve = (function(name, age, weight, height){
    let calculateBmi = (weight, height) => {
        return Math.round(weight / (height / 100) / (height / 100));
    };

    let calculateStatus = (bmi) => {
        let status = '';
        if (bmi < 18.5) {
            status = 'underweight';
        } else if (bmi < 25) {
            status = 'normal';
        } else if (bmi < 30) {
            status = 'overweight';
        } else {
            status = 'obese';
        }
        return status;
    }

    let createPerson = (name, age, weight, height, bmi, status) => {
        let personObj = {
            name: name,
            personalInfo: {
                age: age,
                weight: weight,
                height: height,
            },
            BMI: bmi,
            status: status
        };

        if (status === 'obese') {
            personObj['recommendation'] = 'admission required';
        }
        return personObj;
    };

    let bmi = calculateBmi(weight, height);
    let status = calculateStatus(bmi);
    let person = createPerson(name, age, weight, height, bmi, status);
    return person;
});

let person = solve('Petur', 20, 75, 182);
console.log(person.name);
console.log(person.personalInfo.age);
console.log(person.personalInfo.weight);


