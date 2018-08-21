function search(){
    $('#towns li').css('font-weight', '');
    let valueInput = $('#searchText').val();

    let items = $(`#towns li:contains('${valueInput}')`);
    items.css('font-weight', 'bold');
    $('#result').text(items.length + " maches found.");
}