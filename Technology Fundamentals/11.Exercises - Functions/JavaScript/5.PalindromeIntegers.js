function solve(input){
    for(let value of input) {
        let palidrom = isPalidrom(value);
        console.log(palidrom);
    }

    function isPalidrom(value){
        let lastDigit = value.toString() % 10;
        let firstDigit = value.toString()[0];

        if (firstDigit == lastDigit) {
            return true;
        }

        return false;
    }
}
solve([123,323,421,121]);