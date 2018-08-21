function bigNum(matrix){
    let big = Number.NEGATIVE_INFINITY;
    matrix.forEach(
        r => r.forEach(
            c => big = Math.max(big, c)));
    return big;
}