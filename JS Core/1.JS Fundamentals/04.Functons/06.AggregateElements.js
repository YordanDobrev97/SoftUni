function aggregateItems(array){
    function aggregate(array, start, fuct){
        let initValue = start;
        for(let item of array){
            initValue = fuct(initValue, item);
        }
        console.log(initValue);
    }

    aggregate(array, 0, (a, b) => a + b);
    aggregate(array, 0, (a, b) => a + 1 / b);
    aggregate(array, '', (a, b) => a + b);
}