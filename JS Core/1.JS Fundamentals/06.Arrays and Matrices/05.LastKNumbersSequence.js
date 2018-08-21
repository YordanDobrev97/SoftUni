function lastKNums(n, k){
    let sum = (a, b) => a + b;
    let sequence = [1];

    for(let i = 1; i<n; i++){
        let numbersTakeItems = (sequence.length - k) < 0 ? 0: sequence.length - k;
        let item = sequence.slice(numbersTakeItems).reduce(sum);
        sequence.push(item);
    }
    console.log(sequence.join(' '));
}