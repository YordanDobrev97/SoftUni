const baseUrl = "https://books-6555d.firebaseio.com/.json";

document.getElementById("loadBooks").addEventListener("click", loadBooks);
document.querySelector('form:nth-child(3) > button:nth-child(8)').addEventListener('click', submitData);

function loadBooks() {
    let template = `<tr id={key}>
    <td>{value}</td>
    <td>{value}</td>
    <td>{value}</td>
    <td>
        <button class="edit">Edit</button>
        <button class="delete">Delete</button>
    </td>
</tr>`;

    const tbody = document.getElementsByTagName('tbody')[0];
    tbody.remove();
    
    const newTBody = document.createElement('tbody');

    fetch(baseUrl)
        .then(request => request.json())
        .then(data => {
            renderHTML(data, template, newTBody);
        }).then(() => {
            addEventButtons();
        })
}

function renderHTML(data, template, newTBody) {
    for (let bookData of Object.entries(data)) {
        const title = bookData[1].title;
        const author = bookData[1].author;
        const isbn = bookData[1].isbn;

        let currentTemplate = template;

        currentTemplate = currentTemplate.replace('{key}', bookData[0]);
        currentTemplate = currentTemplate.replace('{value}', title);
        currentTemplate = currentTemplate.replace('{value}', author);
        currentTemplate = currentTemplate.replace('{value}', isbn);

        newTBody.innerHTML += currentTemplate;
    }

    const table = document.getElementsByTagName('table')[0];
    table.appendChild(newTBody);
}

function addEventButtons() {
    const editButtons = document.querySelectorAll('.edit');
    [...editButtons].forEach(editButton => {
        editButton.addEventListener('click', editBook);
    });
    const deleteButtons = document.querySelectorAll('.delete');
    [...deleteButtons].forEach(deleteButton => {
        deleteButton.addEventListener('click', deleteBook);
    });
}

function deleteBook(e) {
    e.preventDefault();

    const tableRow = this.parentNode.parentNode;
    tableRow.remove();

    const id = tableRow.getAttribute('id');
    const currentUrl = baseUrl.replace('.json', id) + '.json';

    fetch(currentUrl, {
        method: 'DELETE'
    });
}

function editBook(e) {
    e.preventDefault();

    const template = `<form class="edit-data">
        <h3>Edit</h3>
        <label>TITLE</label>

        <input class="title" placeholder="Title..." >

        <label>AUTHOR</label>
        <input class="author" placeholder="Author...">

        <label>ISBN</label>
        <input class="isbn" placeholder="ISBN...">

        <button class="send">Send</button>
</form>`;

    const tableRow = this.parentNode.parentNode;
    tableRow.parentNode.parentNode.insertAdjacentHTML('afterend', template);

    const id = tableRow.getAttribute('id');
    sendData(id);
}

function sendData(id) {
    document.querySelector('.send').addEventListener('click', function(e){
        e.preventDefault();

        const editTitle = document.querySelector('.title').value;
        const editAuthor = document.querySelector('.author').value;
        const editIsbn = document.querySelector('.isbn').value;

        const editUrl = baseUrl.replace('.json', `${id}.json`);
        
        const updateData = {
           title: editTitle,
           author: editAuthor,
           isbn: editIsbn
        };

        fetch(editUrl, {
            method: 'PATCH',
            body: JSON.stringify(updateData)
        }).then(() => {
           document.querySelector('.edit-data').remove();
        });
    });
}

function submitData(e) {
    e.preventDefault();

    const title = document.getElementById('title');
    const author = document.getElementById('author');
    const isbn = document.getElementById('isbn');

    const newBook = {
        title: title.value,
        author: author.value,
        isbn: isbn.value
    }

    fetch(baseUrl, {
        method: 'POST',
        body: JSON.stringify(newBook)
    }).then(() => {
        renderSuccessDiv();
    });
}

function renderSuccessDiv() {
    const successDiv = document.createElement('div');
    successDiv.style.backgroundColor = '#7CFC00';
    successDiv.style.width = '20%';
    successDiv.style.margin = '0 auto';
    successDiv.style.height = '30px';
    successDiv.style.display = 'center';
    successDiv.className = 'success';
    successDiv.textContent = 'Success creating book!';
    document.body.appendChild(successDiv);

    setTimeout(() => {
        document.querySelector('.success').remove();
    }, 1000);
}