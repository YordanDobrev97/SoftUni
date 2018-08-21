function extractText(){
    let items = $('#items li')
    .toArray()
    .map(li => li.textContent).join(', ');

    $('#result').text(items);
}