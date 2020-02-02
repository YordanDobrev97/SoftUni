function solution() {
  const button = document.querySelector('.card div button');
  const ul = document.querySelector('.card ul');

  button.addEventListener('click', () => {
    const gifName = document.querySelector('.card div input');
    const li = document.createElement('li');
    li.setAttribute('class', 'gift');
    li.textContent = gifName.value;

    const sendButton = document.createElement('button');
    sendButton.setAttribute('id', 'sendButton');
    sendButton.textContent = 'Send';

    const discardButton = document.createElement('button');
    discardButton.setAttribute('id', 'discard');
    discardButton.textContent = 'Discard';

    li.appendChild(sendButton);
    li.appendChild(discardButton);

    ul.appendChild(li);

    gifName.value = '';

    const buttons = document.querySelectorAll('.card ul');

    Array.from(buttons).map(button => {
      button.onclick = function(e) {
        const currentGift = e.target.parentNode.firstChild.nodeValue;
        let index = 2;
        if (e.target.textContent === 'Discard') {
            index = 3;
        }

        const listGifts = document.querySelectorAll('.card')[index];
        const li = document.createElement('li');
        li.textContent = currentGift
        e.target.parentNode.remove();
        listGifts.children[1].appendChild(li);
      };
    });
  });
}
