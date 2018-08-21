function increment() {
    let wrapper = $('#wrapper');
    let textArea = $('<textarea class="counter" value="" disabled="">');
    textArea.val(0);
    $('#wrapper').append(textArea);

    let incrementBtn = $('<button class="btn" id="incrementBtn">Increment</button>')
    .on('click', function(){
        let increment = +textArea.val() + 1;
        textArea.val(increment);
    });
    let ul = $('<ul class="results"></ul>');
    let addBtn = $('<button class="btn" id="addBtn">Add</button>')
    .on('click', function(){
        let li = $(`<li>${textArea.val()}</li>`);
        $('.results').append(li);

    });
    $('#wrapper').append(incrementBtn);
    $('#wrapper').append(addBtn);
    $('#wrapper').append(ul);
}
