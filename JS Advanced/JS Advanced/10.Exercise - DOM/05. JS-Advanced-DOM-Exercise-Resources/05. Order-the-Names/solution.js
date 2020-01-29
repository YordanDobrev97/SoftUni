function solve() {
    const button = document.querySelector('button');
    const list = document.querySelectorAll('li');

    button.addEventListener('click', (e) => {
        const username = document.querySelector('input').value;
        const firstLetter = username[0].toUpperCase();
        const index = firstLetter.charCodeAt() - 65;
        const name = `${firstLetter}${username.substring(1).toLowerCase()}`;

        if (list[index].innerHTML === '') {
            console.log('falsy value');
            list[index].innerHTML += name;
        } else {
            list[index].innerHTML += `, ${name}`;
        }
    });
}