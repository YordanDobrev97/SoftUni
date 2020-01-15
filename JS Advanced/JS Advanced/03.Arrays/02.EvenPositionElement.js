function getItemEvenIndex(array) {
    let items = [];
    for (let i = 0; i < array.length; i++) {
        if (i % 2 === 0) {
            items.push(array[i]);
        }
    }
    return items.join(' ').trim();
}

console.log(getItemEvenIndex(['5', '10']));
