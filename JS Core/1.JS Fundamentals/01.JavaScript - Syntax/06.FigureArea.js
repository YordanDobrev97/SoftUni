function calcArea(width1, height1, Width2, Height2){
    let s1 = width1 * height1;
    let s2 = Width2 * Height2;
    let s3 = Math.min(width1, Width2) * Math.min(height1 , Height2);

    console.log(s1 + s2 - s3);
}