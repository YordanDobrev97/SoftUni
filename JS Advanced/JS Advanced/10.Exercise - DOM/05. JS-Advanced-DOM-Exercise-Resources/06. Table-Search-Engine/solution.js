function solve() {
   const button = document.getElementById('searchBtn');
   button.addEventListener('click', () => {
      let searchValue = document.getElementById('searchField').value;
      const rows = document.querySelectorAll('tbody > tr');
      
      for (let i = 0; i < rows.length; i++) {
         const element = rows[i];
         let values = element.textContent.split('\n').filter(x => x !== '' && x.trim());
         values = values.map(el => el.trim());

         for(let item of values) {
            if (item.includes(searchValue)) {
               rows[i].className = 'select';
            }
         }
      }
      document.getElementById('searchField').value = '';
   })
}