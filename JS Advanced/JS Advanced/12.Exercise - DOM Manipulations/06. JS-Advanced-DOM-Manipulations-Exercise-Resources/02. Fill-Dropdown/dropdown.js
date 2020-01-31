function addItem() {
  const text = document.getElementById('newItemText').value;
  const value = document.getElementById('newItemValue').value;
  const option = document.createElement('option');

  option.value = value;
  option.innerHTML = text;

  document.getElementById('menu').appendChild(option);

  document.getElementById('newItemText').value = '';
  document.getElementById('newItemValue').value = '';
 
}
