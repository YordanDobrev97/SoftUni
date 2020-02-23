function solve(){
   const createBtn = document.querySelector('.btn');

   createBtn.addEventListener('click', (e)=>{
      e.preventDefault();

      const author = document.getElementById('creator');
      const title = document.getElementById('title');
      const category = document.getElementById('category');
      const content = document.getElementById('content');

      const parent = document.querySelector('.site-content > main > section');
      const article = createHTMLElement('article');

      const h1 = createHTMLElement('h1', title.value);
      const pCategory = createHTMLElement('p', 'Category:');
      const strong = createHTMLElement('strong', category.value);

      const pCreator = createHTMLElement('p', 'Creator:');
      const strongCreator = createHTMLElement('strong', author.value);

      const pContent = createHTMLElement('p', content.value);

      const divBtns = createHTMLElement('div', null, 'buttons');
      const deleteBtn = createHTMLElement('button', 'Delete', 'btn delete');
      const archiveBtn = createHTMLElement('Button', 'Archive', 'btn archive');

      archiveBtn.addEventListener('click', function() {
         const archiveSectionUl = document.querySelector('.archive-section > ul:nth-child(2)');
         archiveSectionUl.innerHTML = '';

         const allArchives = this.parentNode.parentNode;
         console.log(allArchives);

         this.parentNode.parentNode.remove();
      });

      deleteBtn.addEventListener('click', function() {
         this.parentNode.parentNode.remove();
      });

      article.appendChild(h1);

      pCategory.appendChild(strong);
      article.appendChild(pCategory);

      pCreator.appendChild(strongCreator);
      article.appendChild(pCreator);

      article.appendChild(pContent);

      divBtns.appendChild(deleteBtn);
      divBtns.appendChild(archiveBtn);

      article.appendChild(divBtns);

      parent.appendChild(article);
   })
   
   function createHTMLElement(tagName, textContent, className, attributes) {
      const element = document.createElement(tagName);

      if (textContent) {
         element.textContent = textContent;
      }

      if (className) {
         element.className = className;
      }

      return element;
   }
}