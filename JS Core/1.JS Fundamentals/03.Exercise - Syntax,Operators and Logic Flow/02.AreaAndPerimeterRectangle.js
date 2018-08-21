function areaAndPerimeter(sideA, sideB){
    // Math.PI * r * r
    let area = sideA * sideB;
    //2a + 2b = 2.(a + b).
    let perimeter = 2 * sideA + 2 * sideB;
    console.log(area.toFixed(2));
    console.log(perimeter.toFixed(2));
}