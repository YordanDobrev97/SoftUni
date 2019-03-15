function distancePoints(x1,y1,x2, y2){

    let distance = calculateDistance(x1, y1, x2, y2);
    console.log(distance);

    function calculateDistance(x1, y1,x2, y2){
        let x = x1 - x2;
        let y = y1 - y2;

        let sqr = Math.sqrt(x * x + y * y);

        return sqr;
    }
}
distancePoints(2,4,5,0);
distancePoints(2.34,15.66,-13.55,-2.9985);