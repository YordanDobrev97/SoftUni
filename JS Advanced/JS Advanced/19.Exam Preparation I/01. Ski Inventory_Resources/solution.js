function solve() {
  const addButton = document.querySelector('#add-new button');
  const filterButton = document.querySelector('.filter button');
  const buyButton = document.querySelector('#myProducts button');

  //add product in Available products
  addButton.addEventListener('click', (e) => {
     e.preventDefault();

     const items = document.querySelectorAll('#add-new input');
     const name = items[0].value;
     const quantity = Number(items[1].value);
     const price = Number(items[2].value).toFixed(2);
     const ul = document.querySelector('#products ul');
     const li = createHTMLElement('li');
     const span = createHTMLElement('span', name);
     const strong = createHTMLElement('strong', `Available: ${quantity}`);
     const div = createHTMLElement('div');
     const strongDiv = createHTMLElement('strong', price);
     const buttonClientList = createHTMLElement('button', "Add to Client's List");
     buttonClientList.addEventListener('click', addToClientList);

     li.appendChild(span);
     li.appendChild(strong);
     div.appendChild(strongDiv);
     div.appendChild(buttonClientList);
     li.appendChild(div);

     ul.appendChild(li);
  });

  filterButton.addEventListener('click', (e) => {
      e.preventDefault();
      const inputValue = document.querySelector('#filter').value.toLowerCase();
      
      const products = document.querySelectorAll('#products ul li');
      for(let product of products) {
         const spanNameProduct = product.querySelector('span').textContent;
         if (!spanNameProduct.includes(inputValue)) {
            product.style.display = 'none';
         }
      }
  });

  buyButton.addEventListener('click', (e) => {
      e.preventDefault();
      const ulElements = document.querySelector('#myProducts ul');
      ulElements.textContent = "";
      document.querySelectorAll('h1')[1].textContent = "Total Price: 0.00";
  });

  function addToClientList() {
     //add in myProducts
     const li = this.parentNode.parentNode;
     const ulMyProducts = document.querySelector('#myProducts ul');
     const name = li.querySelector('span');
     let price = li.querySelector('div strong').textContent;
     
     const liClientList = createHTMLElement('li');
     const strong = createHTMLElement('strong', price);
     liClientList.textContent = name.textContent;
     liClientList.appendChild(strong);

     ulMyProducts.appendChild(liClientList);

     //decreasing quantity product
     const available = li.querySelector('strong');
     const newQuantity = Number(available.textContent.split(': ')[1]) - 1;

     if (newQuantity <= 0) {
        li.remove();
     } else {
         available.textContent = `Available: ${newQuantity}`;
     }
     
     //change totalPrice
     let totalPrice = document.querySelectorAll('h1')[1];
     let currentPrice = totalPrice.textContent.split(': ')[1];
     const newPrice = Number(currentPrice) + Number(price);
     console.log(+currentPrice + 23.50);
     totalPrice.textContent = `Total price: ${newPrice.toFixed(2)}`;
  }

  function createHTMLElement(tagName, textContent, className, attributes) {
     const element = document.createElement(tagName);

     if (textContent){
        element.textContent = textContent;
     }

     if (className) {
        element.className = className;
     }

     return element;
  }
}