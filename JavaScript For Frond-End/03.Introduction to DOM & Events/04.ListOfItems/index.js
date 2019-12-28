function addItem() {
    let newItemText = document.getElementById('newItemText').value;

    let li = document.createElement('li');
    li.textContent=newItemText;
    let items = document.getElementById('items');

    items.appendChild(li);
    document.getElementById('newItemText').value = '';
}