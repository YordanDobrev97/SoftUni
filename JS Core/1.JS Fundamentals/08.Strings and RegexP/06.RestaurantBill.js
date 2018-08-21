function restaurantBill(array){
    let purchases = [];
    let totalPrice = 0;
    for(let i = 0; i < array.length; i++){
        if(i % 2 == 0){
            let nameProduct = array[i];
            purchases.push(nameProduct);
        }else{
            let priceProduct = Number(array[i]);
            totalPrice +=priceProduct;
        }
    }
    console.log(`You purchased ${purchases.join(", ")} for a total sum of ${totalPrice}`);
}