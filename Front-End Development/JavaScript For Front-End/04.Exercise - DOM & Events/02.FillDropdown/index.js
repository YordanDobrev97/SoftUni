function addItem() {
    let textUser = document.getElementById('newItemText').value;
    let valueUser = document.getElementById('newItemValue').value;

    let option = document.createElement('option');
    option.value = valueUser;
    option.text = valueUser;
    document.getElementById('menu').appendChild(option);
    
    document.getElementById('newItemText').value = '';
    document.getElementById('newItemValue').value = '';
}