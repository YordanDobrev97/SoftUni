let solution = (function(){
    function add(vector1,vector2){
        let firstVector = vector1[0] + vector2[0];
        let secondVector = vector1[1] + vector2[1];
        return [`${firstVector}, ${secondVector}`];
    }
    function multiply(vector1, scalar){
        let firstMupltiply = vector1[0] * scalar;
        let secondMupltiply = vector1[1] * scalar;
        return [`${firstMupltiply}, ${secondMupltiply}`];
    }
    function length(vector1){
        let firstLength = vector1[0] * vector1[0];
        let secondLength = vector1[1] * vector1[1];
        let sum = firstLength + secondLength;
        return Math.sqrt(sum);
    }
    function dot(vector1, vector2){
        let firstDot = vector1[0] * vector2[0];
        let secondDot = vector1[1] * vector2[1];
        let sum = firstDot + secondDot;
        return sum;
    }
    function cross(vector1,vector2){
        let first = vector1[0] * vector2[1];
        let second = vector1[1] * vector2[0];
        let sub = first - second;
        return sub;
    }

    return {
        add: add,
        multiply: multiply,
        length: length,
        dot: dot,
        cross: cross
    }
})();
console.log(solution.add([1, 1], [1, 0]));
console.log(solution.multiply([3.5, -2], 2));
console.log(solution.length([3, -4]));
console.log(solution.dot([1, 0], [0, -1]));
console.log(solution.cross([3, 7], [1, 0]));