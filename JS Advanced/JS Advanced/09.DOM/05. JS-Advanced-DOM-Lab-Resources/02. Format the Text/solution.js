function solve() {
   let p = document.getElementById('input');
   let sequence = p.textContent.split('.');
   
   let output = document.getElementById('output');

   for (let i = 0; i < sequence.length; i+=3) {
      let text = sequence.slice(i, i + 3);
      
      let newParagraph = document.createElement('p');
      newParagraph.textContent = text;

      output.appendChild(newParagraph);
   }
}