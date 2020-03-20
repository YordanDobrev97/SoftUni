import baseUrl from './firebase.js';

const root = document.getElementById('root');

async function loadTowns() {
    root.innerHTML = '';

    const townFromDb = await (await fetch(baseUrl)).json();
    
    const templateData = await (await fetch('./templates/towns.hbs')).text();
    const townObject = {
        towns: []
    };
    
    Object.keys(townFromDb).forEach(town => {
        const value = townFromDb[town].town;
        townObject.towns.push({town: value});
    });

    const template = Handlebars.compile(templateData);
    const endData = template(townObject);
    
    root.innerHTML += endData;
}

export default loadTowns;