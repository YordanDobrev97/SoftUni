function addItem(){
    let getTextValue = document.getElementById('newItemText');
    let getValue = document.getElementById('newItemValue');
    let menu = document.getElementById('menu');

    let option = document.createElement('option');
    option.setAttribute('value', getTextValue.value);
    option.setAttribute('value', getValue.value);
    
    option.text =  getTextValue.value;
    menu.appendChild(option);
}