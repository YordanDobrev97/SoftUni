function create(words) {
   for (let i = 0; i < words.length; i++) {
      createDiv(i);
   }

   document.getElementById('content').addEventListener('click', (e) => {
      e.target.children[0].style.display = 'block';
   })
   function createDiv(index) {
      const div = document.createElement('div');
      const p = document.createElement('p');
      p.textContent = words[index];
      p.style.display = 'none';
      div.appendChild(p);
      document.getElementById('content').appendChild(div);
   }
}