function insideVolumePoint(array){
    const[x1,x2,y1,y2,z1,z2] = [10,50,20,80,15,50];
    let isInside = (x,y,z) => 
        x1 <=x && x <=x2 
        && y1 <= y && y <= y2
        && z1 <= z && z <= z2;

    for(let i = 0; i<array.length; i+=3){
        let pointInside = isInside(array[i], array[i + 1], array[i + 2]);
        console.log(pointInside ? 'inside': 'outside');
    }
}