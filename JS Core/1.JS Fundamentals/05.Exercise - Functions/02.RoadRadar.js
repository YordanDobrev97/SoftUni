function roadRadar(input){
    let speed = input[0];
    let road = input[1];

    let getRoadSpeed = function(road){
        let result = {
            motorway : 130,
            interstate : 90,
            city : 50,
            residential : 20
        };
        return result[road];
    }

    let speedDiff = speed - getRoadSpeed(road);
    speedResult(speedDiff);

    function speedResult(speedDiff){
        let result;
        if(speedDiff <=0){
            return;
        }else if(speedDiff <=20){
            result = 'speeding';
        }else if(speedDiff <= 40){
            result = 'excessive speeding';
        }else {
            result = 'reckless driving';
        }
        console.log(result);
    }
}