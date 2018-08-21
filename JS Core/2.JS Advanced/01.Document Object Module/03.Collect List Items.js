function extractText() {
    let getId = document.getElementById('items').children;
    let resultId = document.getElementById('result');
    for(let item of getId)
    {
        let last = item.textContent + "\n";
        resultId.value += last;
    }
    
}