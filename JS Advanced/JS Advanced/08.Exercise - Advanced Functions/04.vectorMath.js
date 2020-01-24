const vector = (function() {
    return {
        add: (vector1, vector2) => {
           let [x1, y1] = vector1;
           let [x2, y2] = vector2;
           let xSum = x1 + x2;
           let ySum = y1 + y2;
           return [xSum, ySum];
        },
        multiply: (vector1, scalar) => {
            let [x1, y1] = vector1;
            let xSum = x1 * scalar;
            let ySum = y1 * scalar;
            return [xSum, ySum];
        },
        length: (vector1) => {
            let [x1, y1] = vector1;
            return Math.sqrt(x1 * x1 + y1 * y1);
        },
        dot: (vector1, vector2) => {
            let [x1, y1] = vector1;
            let [x2, y2] = vector2;
            let x = x1 * x2;
            let y = y1 * y2;
            return x + y;
        },
        cross: (vector1, vector2) => {
            let [x1, y1] = vector1;
            let [x2, y2] = vector2;
            let x = x1 * y2;
            let y = y1 * x2;
            return x - y;
        }
    }
});

let solution = vector();

let result = solution.cross([3, 7], [1, 0]);
console.log(result);
