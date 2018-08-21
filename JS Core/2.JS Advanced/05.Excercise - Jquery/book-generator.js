function createBook() {
    let div = $('<div>');
    div.attr('id', 'book1');
    div.css('style', 'border');
    div.appendTo('#wrapper');

    let pTitle = $('<p>');
    pTitle.addClass('title');
    pTitle.text('Alice in Wonderland');
    pTitle.appendTo(div);

    let pAuthor = $('<p>');
    pAuthor.addClass('authour');
    pAuthor.text('Lewis Carroll');
    pAuthor.appendTo(div);

    let pIsbn = $('<p>');
    pIsbn.addClass('isbn');
    pIsbn.text('1111');
    pIsbn.appendTo(div);

    let selectBtn = $('<button>');
    selectBtn.text('Select');
    selectBtn.appendTo(div);

    selectBtn.on('click', function(){
        $('#wrapper').css('border', '2px solid blue');
    })

    // selectBtn.on('click', function(){
//;
    // });

    let deselectBtn = $('<button>');
    deselectBtn.text('Deselect');
    deselectBtn.appendTo(div);

    deselectBtn.on('click', function(){
        $('#wrapper').css('border', 'none');
    })
}
