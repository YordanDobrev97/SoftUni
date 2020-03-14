const baseUrl = 'https://fisher-game.firebaseio.com/catches';

function postData(angler, weight, species, location, bait, captureTime) {
    const newData = {
        angler: angler.value,
        weight: weight.value,
        species: species.value,
        location: location.value,
        bait: bait.value,
        captureTime: captureTime.value
    }

    const postUrl = baseUrl + '.json';

    fetch(postUrl, {
        method: 'POST',
        body: JSON.stringify(newData),
        headers: {
            'Content-Type': 'application/json'
        }
    });
}

function load() {
    const loadUrl = baseUrl + '.json';

    document.getElementById('catches').innerHTML = '';
    
    fetch(loadUrl)
        .then(request => request.json())
        .then(data => {
            Object.entries(data).forEach(kvp => {
                const resultDiv = renderHTMLElements(kvp);
                document.getElementById('catches').appendChild(resultDiv);
            })
        })
}

function renderHTMLElements(kvp) {
    const newLine = createHTMLElement('hr');
    const div = createHTMLElement('div', null, 'catch', {id: kvp[0]});

    const labelAngler = createHTMLElement('label', 'Angler');
    const inputAngler = createHTMLElement('input', null, 'angler', {value: kvp[1].angler})

    const labelWeight = createHTMLElement('label', 'Weight');
    const inputWeight = createHTMLElement('input', null, 'weight', {value: kvp[1].weight});

    const labelSpecies =  createHTMLElement('label', 'Species');
    const inputSpecies = createHTMLElement('input', null, 'species', {value: kvp[1].species});

    const labelLocation = createHTMLElement('label', 'Location');
    const inputLocation = createHTMLElement('input', null, 'location', {value: kvp[1].location});

    const labelBait = createHTMLElement('label', 'Bait');
    const inputBait = createHTMLElement('input', null, 'bait', {value: kvp[1].bait});

    const labelCaptureTime = createHTMLElement('label', 'CaptureTime');
    const inputCaptureTime = createHTMLElement('input', null, 'captureTime', {type: 'number', value: kvp[1].captureTime});

    const updateButton = createHTMLElement('button', 'Update', 'update');
    updateButton.addEventListener('click', update);

    const deleteButton = createHTMLElement('button', 'Delete', 'delete');
    deleteButton.addEventListener('click', deleteBtn);

    div.appendChild(labelAngler);
    div.appendChild(inputAngler);
    div.appendChild(newLine);

    div.appendChild(labelWeight);
    div.appendChild(inputWeight);
    div.appendChild(newLine);

    div.appendChild(labelSpecies);
    div.appendChild(inputSpecies);
    div.appendChild(newLine);

    div.appendChild(labelLocation);
    div.appendChild(inputLocation);
    div.appendChild(newLine);

    div.appendChild(labelBait);
    div.appendChild(inputBait);
    div.appendChild(newLine);

    div.appendChild(labelCaptureTime);
    div.appendChild(inputCaptureTime);
    div.appendChild(newLine);

    div.appendChild(updateButton);
    div.appendChild(deleteButton);

    return div;
}

function deleteBtn() {
    const id = this.parentNode.getAttribute('id');
    this.parentNode.remove();

    const deleteUrl = baseUrl + `/${id}.json`;
    fetch(deleteUrl, {
        method: 'DELETE'
    });
}   

function update() {
    const dataDiv = this.parentNode;

    const newAngler = dataDiv.querySelector('.angler').value;
    const weight = dataDiv.querySelector('.weight').value;
    const species = dataDiv.querySelector('.species').value;
    const location = dataDiv.querySelector('.location').value;
    const bait = dataDiv.querySelector('.bait').value;
    const captureTime = dataDiv.querySelector('.captureTime').value;

    const updateData = {
        angler: newAngler,
        bait: bait,
        captureTime: captureTime,
        location: location,
        species: species,
        weight: weight
    }
    const id = this.parentNode.getAttribute('id');
    
    const updateUrl = baseUrl + `/${id}.json`;

    fetch(updateUrl, {
        method: 'PUT',
        body: JSON.stringify(updateData),
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(data => {
        load();
    })
    .catch(err => {
        console.log(err);
    })
}

function createHTMLElement(tagName, textContent, className, attributes) {
    const element = document.createElement(tagName);

    if (textContent) {
        element.textContent = textContent;
    }

    if (className) {
        element.className = className;
    }

    if (attributes) {
        Object.keys(attributes).forEach(key => {
            const value = attributes[key];
            element.setAttribute(key, value);
        });
    }

    return element;
}

export {
    postData,
    load,
}