function initializeTable() {
    $('#createLink').on('click', create)

    addCountryToTable('Bulgaria', 'Sofia');
    addCountryToTable('Germany', 'Berlin');
    addCountryToTable('Russia', 'Moscow');
    hideButton();

    function addCountryToTable(country, capital) {
        let row = $('<tr>')
          .append($("<td>").text(country))
          .append($("<td>").text(capital))
          .append($('<td>')
          .append($('<a href="#">[Up]</a>').on('click', moveUp))
          .append($('<a href="#">[Down]</a>').on('click', moveDown))
        .append($('<a href="#">[Delete]</a>').on('click', deleteRow)));

        $("#countriesTable").append(row);
        row.fadeIn();  
    }
    function moveUp(){
        let row = $(this).parent().parent();
        row.fadeOut(function(){
            row.insertBefore(row.prev());
            row.fadeIn();
            hideButton();
        })
    }
    function moveDown(){
        let row = $(this).parent().parent();
        row.fadeOut(function(){
            row.insertAfter(row.next());
            row.fadeIn();
            hideButton();
        })
    }
    function deleteRow(){
        $(this).parent().parent().remove();
        hideButton();
    }
    function create(){
         let countryVal = $('#newCountryText').val();
         let capicalVal = $('#newCapitalText').val();  
       
         addCountryToTable(countryVal,capicalVal);
         $('#newCountryText').val('');
         $('#newCapitalText').val('');
         hideButton();
    }
    function hideButton(){
        $('#countriesTable a').css('display', 'inline');

        let tableRows = $('#countriesTable tr');
  $(tableRows[2]).find("a:contains('Up')")
    .css('display', 'none');

    $(tableRows[tableRows.length - 1]).find("a:contains('Down')")
    .css('display', 'none');


    }
}
