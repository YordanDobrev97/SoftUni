function isInfraction(input) {
    let speed = Number(input.shift());
    let area = input.shift();
    function overflowLimited (userSpeed, maxSpeed) {
        if (userSpeed - maxSpeed == 0) {
          return '';
        }
        else if (userSpeed - maxSpeed <= 20) {
           return 'speeding';
        } else if (userSpeed - maxSpeed <= 40) {
           return 'excessive speeding';
        } else {
          return 'reckless driving';
        }
    }

    let maxSpeed = {
      'motorway': 130,
      'interstate': 90,
      'city': 50,
      'residential': 20
    };

    let currentMaxSpeed = maxSpeed[area];
    let result = overflowLimited(speed, currentMaxSpeed);
    console.log(result);
}
isInfraction([120, 'interstate']);
