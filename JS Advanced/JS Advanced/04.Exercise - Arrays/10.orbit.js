function buildOrbit(input) {
    let [rows, cols, y, x] = input;

    function initializeMatrix() {
        let result = [];

        for (let row = 0; row < rows; row++) {
            result[row] = [cols];
            for (let col = 0; col < cols; col++) {
                result[row][col] = 0;
            }
        }
        return result;
    }

    let matrix = initializeMatrix();
    
    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix.length; col++) {
            matrix[row][col] = Math.max(Math.abs(y - row),Math.abs(x - col)) + 1;
        }
    }

    for (let row = 0; row < matrix.length; row++) {
        const elements = matrix[row];
        console.log(elements.join(' '));
    }
}

buildOrbit([3, 3, 2, 2]);