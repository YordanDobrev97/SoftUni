function solution() {
  const addButton = document.querySelector('.container section.card div button');
  const ul = document.querySelector('ul');

  addButton.addEventListener('click', () => {
    const giftName = document.querySelector('.container > section.card > div > input');
    const li = createHTMLElement('li', giftName.value, 'gift');
    const sendBtn = createHTMLElement('button', 'Send', null, {id: 'sendButton'});
    const discardBtn = createHTMLElement('button', 'Discard', null, {id: 'discardButton'})
    
    sendBtn.addEventListener('click', sendButton);
    discardBtn.addEventListener('click', discardButton);

    li.appendChild(sendBtn);
    li.appendChild(discardBtn);
    ul.appendChild(li);

    giftName.value = '';
  });

  function sendButton() {
      const sendButtons = document.querySelectorAll('button#sendButton');
      Array.from(sendButtons).forEach(button => {
         if (this == button){
           const li = this.parentNode;
           const sendGiftSection = document.querySelectorAll('.card')[2];
           const ulSendGift = sendGiftSection.querySelector('ul');

           const newLi = createHTMLElement('li', li.textContent, 'gift');
           li.remove();
           ulSendGift.appendChild(newLi);
         }
      });
  }

  function discardButton() {
     const discardButtons = document.querySelectorAll('button#discardButton');
     Array.from(discardButtons).forEach(button => {
        if (this === button) {
          const li = this.parentNode;
          const discardGiftSection = document.querySelectorAll('.card')[3];
          const ulDiscardGift = discardGiftSection.querySelector('ul');
         
          const newLi = createHTMLElement('li', li.textContent, 'gift');
          li.remove();
          ulDiscardGift.appendChild(newLi);
        }
     });
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
      Object.keys(attributes).forEach(key => {
          const value = attributes[key];
          element.setAttribute(key, value);
      });
    }
    return element;
  }
}