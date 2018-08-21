function triangleArea(num1, num2, num3){
    let s = (num1 + num2 + num3) / 2;
    //4.75 * (4.75 - 2) * (4.75 - 3.5) * (4.75 - 4)
    let s1 = s - num1;
    let s2 = s - num2;
    let s3 = s - num3;

    let area = s * s1 * s2 * s3;
    let sqr =area;
    console.log(Math.sqrt(area));
}