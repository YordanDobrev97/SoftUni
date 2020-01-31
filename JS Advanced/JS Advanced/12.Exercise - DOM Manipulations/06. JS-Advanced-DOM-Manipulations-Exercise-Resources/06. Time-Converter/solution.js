function attachEventsListeners() {
    const dayButton = document.getElementById('daysBtn');
    const hoursButton = document.getElementById('hoursBtn');
    const minutesButton = document.getElementById('minutesBtn');
    const secondsButton = document.getElementById('secondsBtn');

    const day = document.getElementById('days');
    const hours = document.getElementById('hours');
    const minutes = document.getElementById('minutes');
    const seconds = document.getElementById('seconds');

    dayButton.addEventListener('click', (e) => {
        e.preventDefault();

        hours.value = day.value * 24;
        minutes.value = hours.value * 60;
        seconds.value = minutes.value * 60;
    });

    hoursButton.addEventListener('click', (e) => {
        e.preventDefault();

        day.value = hours.value / 24;
        minutes.value = hours.value * 60;
        seconds.value = minutes.value * 60;
    });

    minutesButton.addEventListener('click', (e) => {
        e.preventDefault();

        days.value = minutes.value / 60 / 24;
        hours.value = minutes.value / 60;
        seconds.value = minutes.value * 60;
        console.log(days.value, hours.value, minutes.value, seconds.value);
    });

    secondsButton.addEventListener('click', (e) => {
        e.preventDefault();

        days.value = seconds.value / 60 / 60 / 24;
        hours.value = seconds.value / 60 / 60;
        minutes.value = seconds.value / 60;
    });
}