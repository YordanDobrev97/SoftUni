function splitExpression(expression){
    let regex = /[)(,;.\s]/;
    let split = expression.split(regex);
    let filter = split.filter(e => e!=='');

    console.log(filter.join('\n'));
}