function extractText() {
    let ul = document.getElementById('items');
    let liItems = document.getElementsByTagName('li');

    let text = '';
    for(let i = 0; i<liItems.length;i++) {
        let value = liItems[i].textContent;
        text += `${value}\n`;
    }

    let textArea = document.getElementById('result');
    textArea.textContent = text;
    
}