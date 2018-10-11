function solve(base, increment){
    let totalMarble = 0;
    let totalLapis = 0;
    var totalStone = 0;
    let currentSize = base;
    let step = 1;
    while(currentSize > 2){
       let size =  currentSize * currentSize;
       let stone = (currentSize -2) * (currentSize - 2);
       let marble = size - stone;

       totalStone +=stone;

       if(step % 5 == 0){
           totalLapis +=marble;
       }else{
           totalMarble +=marble;
       }
       currentSize-=2;
       step++;
    }
    //step++;
    let totalGold = currentSize == 1 ? 1 : 4;

    totalStone = Math.ceil(totalStone * increment);
    totalMarble = Math.ceil(totalMarble * increment);
    totalLapis = Math.ceil(totalLapis * increment);
    totalGold = Math.ceil(totalGold * increment);

    let pyramidHeight = Math.floor(step * increment);
    console.log(`Stone required: ${totalStone}\nMarble required: ${totalMarble}\nLapis Lazuli required: ${totalLapis}\nGold required: ${totalGold}\nFinal pyramid height: ${pyramidHeight}`);
}
solve(11,1);