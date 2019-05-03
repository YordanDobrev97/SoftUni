function cone(radius, height) {
    let volume = (1/3) * Math.PI * radius * radius * height;

    let s = Math.sqrt(radius * radius + height * height);
    let b = Math.PI * radius * radius;
    let l = Math.PI * radius * (Math.sqrt((radius * radius) + (height * height)));
    let total = l + b;

    console.log(`volume = ${volume.toFixed(4)}`);
    console.log(`area = ${total.toFixed(4)}`);
}
cone(3.3,7.8);