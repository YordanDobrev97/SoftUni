import baseUrl from './firebase.js';

function addTown() {
    const values = document.getElementById('towns');
    const splitValues = values.value.split(', ');

    const objectTowns = [];

    splitValues.forEach(town => {
        const townObject = {
            town: town
        }
        
        objectTowns.push(townObject);
    })

    objectTowns.forEach(town => {
        fetch(baseUrl, {
            method: 'POST',
            body: JSON.stringify(town)
        });
    })

    values.value = '';
}

export default addTown;