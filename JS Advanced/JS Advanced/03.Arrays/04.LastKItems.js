function lastKItems(n, k) {
    let sequence = [1];

    for (let i = 0; i < n - 1; i++) {
        let sum = sumLastKItems(k, sequence);
        sequence.push(sum);
    }

    function sumLastKItems(count, array) {
        let sum = 0;
        let currentCount = 0; // 0
        let index = array.length - 1; // 1

        while (currentCount < count) {
            if (!isRange(index, array)) {
                break;
            }

            sum += array[index];
            currentCount++;
            index--;
        }

        return sum;
    }

    function isRange(index, array) {
        return index <= array.length - 1 && index >= 0;
    }

    return sequence;
}
console.log(lastKItems(8, 2));