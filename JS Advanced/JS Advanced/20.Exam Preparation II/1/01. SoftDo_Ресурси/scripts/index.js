function mySolution(){
    const sendButton = document.querySelector('#inputSection div button');
    sendButton.addEventListener('click', () => {
        const question = document.querySelector('#inputSection textarea');
        const textContent = question.value;
        const name = document.querySelector('#inputSection div input');
        const textContentName = name.value ? name.value : "Anonymous";
        
        const div = createHTMLElement('div', null, 'pendingQuestion');
        const image = createHTMLElement('img', null, null, {src: './images/user.png', width: 32, height: 32});
        const span = createHTMLElement('span', textContentName);
        const p = createHTMLElement('p', textContent);
        const actionDiv = createHTMLElement('div', null, 'actions');
        const archiveBtn = createHTMLElement('button', 'Archive', 'archive');
        archiveBtn.addEventListener('click', archiveQuestion);

        const openBtn = createHTMLElement('button', 'Open', 'open');
        openBtn.addEventListener('click', openQuestion);
        actionDiv.appendChild(archiveBtn);
        actionDiv.appendChild(openBtn);

        div.appendChild(image);
        div.appendChild(span);
        div.appendChild(p);
        div.appendChild(actionDiv);

        document.getElementById('pendingQuestions').appendChild(div);

        question.value = '';
    });

    function archiveQuestion() {
        this.parentNode.parentNode.remove();
    }

    function openQuestion() {
        const currentQuestion = this.parentNode.parentNode;
        currentQuestion.className = 'openQuestion';
        const actionDiv = currentQuestion.querySelector('.actions');
        actionDiv.innerHTML = '';   

        const replyBtn = createHTMLElement('button', 'Reply', 'reply');
        const replySection = createHTMLElement('div', null, 'replySection', {style: 'display: none;'});
        const input = createHTMLElement('input', null, 'replyInput',{type: 'text', placeholder: 'Reply to this question here...'});
        const button = createHTMLElement('button', 'Send', 'replyButton');
        button.addEventListener('click', sendAnswer);
        const ol = createHTMLElement('ol', null, 'reply', {type: '1'});

        replyBtn.addEventListener('click', replyQuestion);

        replySection.appendChild(input);
        replySection.appendChild(button);
        replySection.appendChild(ol);

        currentQuestion.appendChild(replySection);

        document.getElementById('openQuestions').appendChild(currentQuestion);
        actionDiv.appendChild(replyBtn);
    }

    function replyQuestion() {
        
        if (document.querySelector('.openQuestion .actions button.reply').textContent === 'Reply') {
            document.querySelector('.openQuestion .actions button.reply').textContent = 'Back';
            document.querySelector('.replySection').style.display = 'block';
        } else {
            document.querySelector('.replySection').style.display = 'none';
            document.querySelector('.openQuestion .actions button.reply').textContent = 'Reply';
        }
    }

    function sendAnswer() {
        console.log('send');
        const sendMessage = document.querySelector('.replyInput').value;
        const liElement = createHTMLElement('li', sendMessage);
        document.querySelector('.replySection .reply').appendChild(liElement);
    }

    function createHTMLElement(tagName, textContent, className, attributes) {
        const element = document.createElement(tagName);

        if (textContent) {
            element.textContent = textContent;
        }

        if (className) {
            element.className = className;
        }

        if (attributes) {
            const properties = Object.keys(attributes);
            properties.forEach(key => {
                const val = attributes[key];
                element.setAttribute(key, val);
            });
        }

        return element;
    }
}