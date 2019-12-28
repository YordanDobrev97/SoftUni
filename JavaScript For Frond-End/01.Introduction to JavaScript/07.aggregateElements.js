function aggregateElements(elements) {
    let sumElements = elements.reduce((a,b) => a + b);
    let sum = inverseSum();
    let concatValues = elements.join('');

    console.log(sumElements);
    console.log(sum);
    console.log(concatValues);

    function inverseSum() {
        let sum = 0;
        for (let i = 0; i < elements.length; i++) {
            sum += 1 / elements[i];
        }
        return sum;
    }
}

aggregateElements([1,2,3]);