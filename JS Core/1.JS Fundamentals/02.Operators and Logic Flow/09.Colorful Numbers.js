function colorfulNums(number){
    let result = '<ul>\n';
    let isGreenColor = true;
    let color = 'green';
    for(let i = 1; i <=number; i++){
        result += '  ';
        result +='<li><span style=\'color:';
        if(i % 2 == 1){
            color = 'green';
        }
        else{
            color = 'blue';
        }
        result +=color;
        result +='\'>';
        result +=i;
        result +='</span></li>\n';
    }
    result += '</ul>';
    console.log(result);

}