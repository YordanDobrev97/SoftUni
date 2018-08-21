function distance(items){
    let dist1 = (items[0] / 3.6) * items[2];
    let dist2 = (items[1] / 3.6) * items[2];
    let delta = Math.abs(dist1 - dist2);
    console.log(delta);  
}