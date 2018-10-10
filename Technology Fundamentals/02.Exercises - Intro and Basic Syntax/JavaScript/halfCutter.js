function cutter(size){
    let pieces = 0;
    do{
        size /=2;
        pieces++;
    }while(size > 1);

    console.log(`Length is ${size.toFixed(2)} cm. after ${pieces} cuts.`);
}
cutter(1000);
cutter(1);