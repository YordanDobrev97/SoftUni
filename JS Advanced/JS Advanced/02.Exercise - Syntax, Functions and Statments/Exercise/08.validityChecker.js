function validityChecker(input) {
    let x1 = input[0];
    let y1 = input[1];
    let x2 = input[2];
    let y2 = input[3];

    function distance(x1, y1, x2, y2) {
        let firstDistancePoint = x1 - x2;
        let secondDistancePoint = y1 - y2;
        return Math.sqrt(firstDistancePoint ** 2+ secondDistancePoint ** 2);
    }

    function isValid(x1, y1, x2, y2) {
        if (Number.isInteger(distance(x1, y1, x2, y2))) {
            return `{${x1}, ${y1}} to {${x2}, ${y2}} is valid`;
        }
        return `{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`;
    }

    console.log(isValid(x1, y1, 0, 0));
    console.log(isValid(x2, y2, 0, 0));
    console.log(isValid(x1, y1, x2, y2));
}
validityChecker([3, 0, 0, 4]);