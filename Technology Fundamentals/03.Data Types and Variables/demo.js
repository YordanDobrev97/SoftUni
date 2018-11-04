function solve(){
    let value = '20';
    console.log(typeof value);
    console.log((+value) + 1);
    console.log(value + 1);
    console.log(typeof value);

    let number = 19;
    let otherNumber = '5';

    console.log(number != otherNumber);
    console.log(number !== otherNumber);

    if(number){
        console.log('Is Number!');
    }else{
        console.log('Not number');
    }
    console.log(!!number);
}
solve();