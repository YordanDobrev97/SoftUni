function deleteByEmail() {
    let email = document.getElementsByName('email')[0].value;
    let column = document.querySelectorAll('#customers tr td:nth-child(2)');

    for(let item of column)
    {
        if(item.textContent === email)
        {
            let row = item.parentNode;
            row.parentNode.removeChild(row);
            document.getElementById('result').textContent = 'Deleted.';
            return;
        }
    }
    document.getElementById('result').textContent = 'Not found.';
}