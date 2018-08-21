function attachEvents() {
    $('#items').on('click','li' ,selectTowns);
    
    $('#showTownsButton').on('click', function(){
        let items = $('#items li[data-selected=true]');
        let toArray = items.toArray()
        .map(el => el.textContent)
        .join(', ');

        //result
        $('#selectedTowns').text('Selected towns: ' + toArray)
    });
    function selectTowns(){
        let element = $(this);
        if(element.attr('data-selected'))
        {
            element.removeAttr('data-selected');
            element.css('background', '');
        }else{
            element.attr('data-selected', 'true');
            element.css('background', '#DDD')
        }
    }        

}
