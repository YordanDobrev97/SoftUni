function filterByAge(mininumAge,  nameFirstPerson, ageFirstPerson,  nameSecondPeron, ageSecondPerson){
    let firstAge = ageFirstPerson;
    let secondAge = ageSecondPerson;

    let result = [];
    if(firstAge >=mininumAge){
        result.push(`{ name: '${nameFirstPerson}', age: ${firstAge} }`);
    }

    if(secondAge >= mininumAge){
        result.push(`{ name: '${nameSecondPeron}', age: ${secondAge} }`);
    }

    for(let item of result){
        console.log(item);
    }
}