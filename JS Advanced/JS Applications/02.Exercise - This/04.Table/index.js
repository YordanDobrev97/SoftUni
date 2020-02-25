function solve() {
  const children = Array.from(document.querySelectorAll("tbody > tr"));
  children.forEach(child => {
     child.addEventListener('click', function(e) {
         e.preventDefault();
         if (this.hasAttribute('style')) {
             this.removeAttribute('style');
         } else {
            children.map(x => x.removeAttribute('style'));
            this.style.backgroundColor = '#413f5e';
         }
     });
  });
}
