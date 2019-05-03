function printChessboard(size) {
    let html = '<div class="chessboard">\n';

    let row = 0;
    for (let i = 0; i < size; i++) {
        html += '    <div>\n';

        for (let j = 0; j < size; j++) {
            if (row % 2 === 0) {
                html += '        <span class="black"></span>\n';
            }else {
                html += '        <span class="white"></span>\n';
            }
            row++;
        }

        html += '    </div>\n';
    }
    html += '</div>\n';

    console.log(html);
}
printChessboard(4);