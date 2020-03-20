(() => {
     renderCatTemplate();

     function renderCatTemplate() {
        fetch('./templates/cat-template.hbs')
        .then(request => request.text())
        .then(data => {
            const template = Handlebars.compile(data);
            const context = {
                cats: []
            }

            this.cats.forEach(cat => {
                const catObject = {
                    id: cat.id,
                    path: `./images/${cat.imageLocation}.jpg`,
                    statusCode: cat.statusCode,
                    message: cat.statusMessage
                }
                context.cats.push(catObject);
            })

            const result = template(context);
            document.querySelector('#allCats').innerHTML += result;
        })
        .then(() => {
            document.querySelectorAll('.showBtn')
                        .forEach(button => {
                            button.addEventListener('click', show);
                        });
        })
     }

     function show() {
        const child = this.parentNode;
        const divInfo = child.querySelector('.status');
        
        if (this.textContent === 'Show status code') {
            divInfo.style.display = 'block';
            this.textContent = 'Hide status code';
        } else {
            divInfo.style.display = 'none';
            this.textContent = 'Show status code';
        }
     }
})();

