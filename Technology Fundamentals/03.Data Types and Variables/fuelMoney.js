function solve(distance, passengers,price){
    let fuel = (distance / 100) * 7;
    fuel += passengers * 0.100;

    let money = price * fuel;
    console.log(`Needed money for that trip is ${money}lv.`);
}
solve(260,9,2.49);