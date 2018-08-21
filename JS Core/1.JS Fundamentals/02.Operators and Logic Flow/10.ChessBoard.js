function printChessBoard(number){
    let result = '<div class="chessboard">\n';

    for(let i = 0; i < number; i++){
        result +='  <div>\n';
        let color = (i % 2 == 0) ? 'black': 'white';
        for(let j = 0; j < number; j++){
            result += `    <span class="${color}"></span>\n`;
            color = (color == 'white'? 'black': 'white');
        }
        result +='  </div>\n';
    }
    result +='</div>';
    console.log(result);
}