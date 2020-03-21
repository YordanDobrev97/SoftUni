async function monkeyTemplate() {
    const baseUrl = 'https://monkeys-e457d.firebaseio.com/.json';

    const monkeysDb = await (await fetch(baseUrl)).json();
    monkeysDb.shift(); // remove first element because he is null

    monkeysDb.forEach(monkey => {
        monkey.image = `./images/${monkey.image}`;
    });
    
    const templateSource = await (await fetch('./templates/monkey-template.hbs')).text();
    
    monkeysDb.forEach(monkey => {
        const template = Handlebars.compile(templateSource);
        const result = template(monkey);

        document.querySelector('.monkeys').innerHTML += result;
    });

    document.querySelectorAll('button').forEach(button => {
        button.addEventListener('click', showInfo);
    });

    function showInfo() {
        const parent = this.parentNode;
        const p = parent.querySelector('p');
        
        if (p.style.display === 'block') {
            p.style.display = 'none';
        } else {
            p.style.display = 'block';
        }
    }
}

monkeyTemplate();