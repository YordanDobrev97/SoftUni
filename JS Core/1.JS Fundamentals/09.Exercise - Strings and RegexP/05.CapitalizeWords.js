function capitalizeFirstLetter(elements) {
    let items = elements.split(' ');
    let filter = items.filter(el => el !== '');
    filter = filter.map(el => el.substr(0,1).toUpperCase() 
    + el.substr(1).toLowerCase());

    console.log(filter.join(' '));
}