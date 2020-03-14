function render(data, currentLocationCode, dataForecast, upcomingData) {
    const forecastViewSymbols = {
        'Sunny': '☀',
        'Rain': '☂',
        'Partly sunny': '⛅',
        'Overcast': '☁',
        'Degrees': '°'
    };

    document.getElementById('forecast').style.display = 'block';
    renderTodayForecast(forecastViewSymbols, dataForecast);
    renderUpcomingForecast(forecastViewSymbols, upcomingData);
}

function renderUpcomingForecast(forecastViewSymbols, upcomingData) {
    const divForecastInfo = createHTMLElement('div', null, 'forecast-info');
    
    upcomingData.forecast.forEach(forecast => {
       const upcomingSpan = createHTMLElement('span', null, 'upcoming');
      
       const symbolSpan = createHTMLElement('span', forecastViewSymbols[forecast.condition], 'symbol');
       const degrees = createHTMLElement('span', `${forecast.low}°/${forecast.high}`, 'forecast-data');
       const nameCondition = createHTMLElement('span', forecast.condition, 'forecast-data');

       upcomingSpan.appendChild(symbolSpan);
       upcomingSpan.appendChild(degrees);
       upcomingSpan.appendChild(nameCondition);

       divForecastInfo.appendChild(upcomingSpan);
   });
   document.getElementById('upcoming').appendChild(divForecastInfo);
}

function renderTodayForecast(forecastViewSymbols, dataForecast) {
    const currentForecastViewSymbol = forecastViewSymbols[dataForecast.forecast.condition];
    const parentDiv = document.getElementById('current');
    const forecastDiv = createHTMLElement('div', null, 'forecasts');
    const conditionSymbolSpan = createHTMLElement('span', currentForecastViewSymbol, 'condition symbol');
    
    const parentSpanCondition = createHTMLElement('span', null, 'condition');
    const name = createHTMLElement('span', dataForecast.name, 'forecast-data');
    const degreesForecast = `${dataForecast.forecast.low}°/${dataForecast.forecast.high}`;
    const forecastData = createHTMLElement('span', degreesForecast, 'forecast-data');
    const conditionName = createHTMLElement('span', dataForecast.forecast.condition, 'forecast-data');
    
    parentSpanCondition.appendChild(name);
    parentSpanCondition.appendChild(forecastData);
    parentSpanCondition.appendChild(conditionName);
    forecastDiv.appendChild(conditionSymbolSpan);
    forecastDiv.appendChild(parentSpanCondition);
    parentDiv.appendChild(forecastDiv);
}

function createHTMLElement(tagName, textContent, className) {
    const element = document.createElement(tagName);

    if (element) {
        element.textContent = textContent;
    }

    if (className) {
        element.className = className;
    }
    return element;
}

export default render;