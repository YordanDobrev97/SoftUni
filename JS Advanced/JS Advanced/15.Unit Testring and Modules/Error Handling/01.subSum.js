function solve(arrayOfNumbers, startIndex, endIndex) {
    if (!Array.isArray(arrayOfNumbers)) {
        return NaN;
    }

    if (startIndex < 0) {
        startIndex = 0;
    }

    if (endIndex > arrayOfNumbers.length - 1) {
        endIndex = arrayOfNumbers.length - 1;
    }
    let sum = 0;
    for (let i = startIndex; i <= endIndex; i++) {
        const value = arrayOfNumbers[i];
        if (!Number(value)) {
            return NaN;
        }
        sum += value;
    }
    return sum;
}

console.log(solve([10, 20, 30, 40, 50, 60], 3, 300));