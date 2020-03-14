import render from './render.js';

function attachEvents() {
  const submitButton = document.getElementById('submit');
  submitButton.addEventListener('click', sendData);

  async function sendData() {
    const input = document.getElementById('location');

    const locationUrl = 'https://judgetests.firebaseio.com/locations.json';
    const data = await (await fetch(locationUrl)).json();
    const currentLocationCode = await (function() {
      for (let location of data) {
        if (input.value === location.name) {
          return location;
        }
      }
    })();

    if (!currentLocationCode) {
        handleInvalidLocation();
    }

    const forecastUrl = `https://judgetests.firebaseio.com/forecast/today/${currentLocationCode.code}.json`;
    const dataForecast = await (await fetch(forecastUrl)).json();

    const upcomingForecastUrl = `https://judgetests.firebaseio.com/forecast/upcoming/${currentLocationCode.code}.json`;
    const upcomingData = await (await fetch(upcomingForecastUrl)).json();

    resetOnValidLocation();
    render(data, currentLocationCode, dataForecast, upcomingData);
    input.value = '';
  }
}

function handleInvalidLocation() {
    const inputField = document.getElementById('location');
    inputField.value = '';
    inputField.style.backgroundColor = 'red';
    inputField.placeholder = 'This is invalid location';
}

function resetOnValidLocation() {
    const inputField = document.getElementById('location');
    inputField.value = '';
    inputField.style.backgroundColor = 'white';
    inputField.placeholder = '';
}

attachEvents();
