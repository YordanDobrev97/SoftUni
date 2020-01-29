function solve() {
   const buttons = document.querySelectorAll('.add-product');
   const titles = document.querySelectorAll('.product-title');
   const productsPrice = document.querySelectorAll('.product-line-price');
   const textarea = document.getElementsByTagName('textarea')[0];
   const checkoutButton = document.querySelector('.checkout');

   const buyProducts = [];
   let totalPrice = 0;
   let message = '';
   Array.from(buttons).map(button => button.addEventListener('click', () =>{
      const indexBtn = Array.from(buttons).indexOf(button);
      const nameProduct = titles[indexBtn].textContent;
      const price = +productsPrice[indexBtn].textContent;
      
      if (!buyProducts.includes(nameProduct)) {
         buyProducts.push(nameProduct);
      }
      totalPrice += price;
      message = `Added ${nameProduct} for ${price.toFixed(2)} to the cart.\n`;
      textarea.textContent += message;
   }));

   checkoutButton.addEventListener('click', () => {
      textarea.textContent += `You bought ${buyProducts.join(', ')} for ${totalPrice.toFixed(2)}.\n`;

      Array.from(buttons).map(button => {
         button.disabled = true;
      })
   });
}