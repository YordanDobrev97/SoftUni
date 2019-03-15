function reverseArray(n, array){
    let outputArray = [];

    for(let i = 0; i < n; i++){
        let element = array[i];
        outputArray.push(element);
    }

    let reversed = outputArray.reverse();
    console.log(reversed.join(' '));
}
reverseArray(3,[10,20,30,40,50]);
reverseArray(2,[66, 43, 75, 89, 47]);
reverseArray(4,[-1, 20, 99, 5]);