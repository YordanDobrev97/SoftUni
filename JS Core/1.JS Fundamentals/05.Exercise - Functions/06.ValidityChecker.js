function validCheker(array){
    function isValidDistance(point1, point2){
        let x = Math.abs(point1.x - point2.x);
        let y = Math.abs(point1.y - point2.y);
        let distance = Math.sqrt(x *x + y * y);
        let result = 
        `{${point1.x}, ${point1.y}} to {${point2.x}, ${point2.y}} is `;
        return parseInt(distance) === distance? result + 'valid': result + 'invalid';
    }
    let firstPoint = {x:0, y:0};
    let secondPoint = {x: array[0], y: array[1]};
    let thirdPoint = {x: array[2], y: array[3]};

    console.log(isValidDistance(secondPoint, firstPoint));
    console.log(isValidDistance(thirdPoint, firstPoint));
    console.log(isValidDistance(secondPoint, thirdPoint));

}