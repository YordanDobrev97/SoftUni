function lastKElements(n,k){
    n = Number(n);
    k = Number(k);
    let elements = [1,1,2];

    while(elements.length < n){
        let sum = getSum();
        elements.push(sum);
    }

    console.log(elements.join(' '));

    function getSum(){
        let lastElements = elements.slice(elements.length - k);

        let sum = 0;

        for(let item of lastElements)
        {
            sum += item;
        }
        return sum;
    }
}
lastKElements(9,5);