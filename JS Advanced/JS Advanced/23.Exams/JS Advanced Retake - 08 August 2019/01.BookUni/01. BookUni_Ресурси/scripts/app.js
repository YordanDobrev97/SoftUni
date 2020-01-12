function solve() {
    const querySelector = document.querySelectorAll('input');

    let button = document.querySelector('button');

    button.addEventListener('click', function(e) {
        const title = querySelector[0].value;
        const year = Number(querySelector[1].value);
        const price = Number(querySelector[2].value);

        if (title === '' || title === ' ' || year < 0 || price < 0) {
            return;
        }

        let bookShelf = document.getElementsByClassName('bookShelf');

        if (year >= 2000) {
            createBook(title, year, price, bookShelf, 1);
        } else {
            createBook(title, year, price, bookShelf, 0);
        }

        e.preventDefault();
    });

    function createBook(title, year, price, bookShelf, indexBookShelf) {
        let div = document.createElement('div');
        div.className = 'book';
        let p = document.createElement('p');
        p.textContent = `${title} [${year}]`;
        let buttonBuy = document.createElement('button');
        buttonBuy.textContent = `Buy it only for ${price.toFixed(2)} BGN`;

        //buy book
        buttonBuy.addEventListener('click', function(e) {
            div.remove();
            let totalProfit = document.getElementsByTagName('h1')[1];
            totalProfit.textContent = `Total Store Profit: ${price.toFixed(2)} BGN`;
            e.preventDefault();
        })

        if (indexBookShelf === 1) {
            let buttonMoved = document.createElement('button');
            buttonMoved.textContent = `Move to old section`;
            div.appendChild(p);
            div.appendChild(buttonBuy);
            div.appendChild(buttonMoved);
            bookShelf[1].appendChild(div);

            //moved new book at old book section
            buttonMoved.addEventListener('click', function(e) {
                div.remove();
                buttonMoved.remove();
                price = price - (price * 0.15);
                buttonBuy.textContent = `Buy it only for ${price.toFixed(2)} BGN`;
                div.appendChild(p);
                div.appendChild(buttonBuy);
                bookShelf[0].appendChild(div);
            });

        } else {
            div.appendChild(p);
            div.appendChild(buttonBuy);
            bookShelf[0].appendChild(div);
        }
    }
}