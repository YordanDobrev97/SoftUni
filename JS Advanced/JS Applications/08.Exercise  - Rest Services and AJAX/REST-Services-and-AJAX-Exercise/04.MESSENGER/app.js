function attachEvents() {
    const baseUrl = 'https://rest-messanger.firebaseio.com/messanger.json';

    document.getElementById('refresh').addEventListener('click', loadMessages);
    document.getElementById('submit').addEventListener('click', sendData);

    function loadMessages() {
        const result = document.getElementById('messages');

        const messages = [];

        fetch(baseUrl)
            .then(request => request.json())
            .then(data => {
                Object.entries(data).forEach(kvp => {
                    const author = kvp[1].author;
                    const content = kvp[1].content;
                   
                    messages.push(`${author}: ${content}`);
                });

            result.textContent = messages.join('\n');
        });
    }

    function sendData() {
        const name = document.getElementById('author');
        const message = document.getElementById('content');

        fetch(baseUrl, {
            method: 'POST',
            body: JSON.stringify({
                author: name.value,
                content: message.value
            })
        });

        name.value = '';
        message.value = '';
    }
}

attachEvents();