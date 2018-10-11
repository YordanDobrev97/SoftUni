function solve(input){
    let priceBictoin = 11949.16;
    let priceGoldGr = 67.51;

    let totalSum = 0;
    let buyBictoinCounter = 0;
    let day = 0;
    let boughtBitcoin = 0;
    let sumBitcoin = 0;
    let firstDay = 0;
    for(let i = 0; i < input.length; i++){
        day++;
        let value = input[i];
        if(day % 3 == 0){
            value *=0.7;
        }
        
        let lv = value * priceGoldGr;
        totalSum +=lv;

        if(totalSum >=priceBictoin){
            buyBictoinCounter++;
            boughtBitcoin = Math.floor(totalSum / priceBictoin);
            totalSum = totalSum - (priceBictoin * boughtBitcoin);
            sumBitcoin +=boughtBitcoin;
        }
        if(buyBictoinCounter == 1){
            firstDay = day;
        }
    }
    console.log(`Bought bitcoins: ${sumBitcoin}`);

    if(firstDay != 0){
        console.log(`Day of the first purchased bitcoin: ${firstDay}`);
    }

    console.log(`Left money: ${totalSum.toFixed(2)} lv.`);
}
solve([100,200,300]);
solve([50,100]);