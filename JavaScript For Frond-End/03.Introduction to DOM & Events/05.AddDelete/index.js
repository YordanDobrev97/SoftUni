function addItem() {
    let inputValue = document.getElementById('newText').value;

    let li = document.createElement('li');
    li.textContent = inputValue;

    let span = document.createElement('span');
    span.innerHTML = '<a href="#" class="delSpan" onclick="deleteItem()">[Delete]</a>';
    span.firstChild.addEventListener('click', deleteItem);
    li.appendChild(span);

    function deleteItem() {
        let li = this.parentNode.parentNode;
        let ul = li.parentNode;
        ul.removeChild(li);
    }

    document.getElementById('items').appendChild(li);
    document.getElementById('newText').value = '';
}