function addSticker(){
    let ul = $('#sticker-list');//.css('display', 'inline-block');
    let inputTitle = $('.title');
    let inputText = $('.content');
    
    let li = $('<li></li>').addClass('node-content');
    let a = $('<a></a>').addClass('button').text('x');
    let h2 = $('<h2></h2>').text(inputTitle.val());
    let hr = $('<hr></hr>');
    let p = $('<p></p>').text(inputText.val());

    ul.append(li);
    li.append(a);
    li.append(h2);
    li.append(hr);
    li.append(p);

    // remove x if click btn
    $('.button').click(function(){
        $(this).closest('li').toggleClass('node-content').fadeOut('fast', function() { $(this).remove()});
       // $('.node-content:selected').remove()
        //$(this).closest('li').remove();
    })
}