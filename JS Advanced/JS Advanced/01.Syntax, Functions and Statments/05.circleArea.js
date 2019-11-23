function calculateCircleArea(input) {
    if (typeof(input) == 'number') {
        let area = Math.pow(input, 2) * Math.PI;
        return area.toFixed(2);
    }

    return `We can not calculate the circle area, because we receive a ${typeof(input)}.`;
}

console.log(calculateCircleArea(5));
console.log(calculateCircleArea('name'));
