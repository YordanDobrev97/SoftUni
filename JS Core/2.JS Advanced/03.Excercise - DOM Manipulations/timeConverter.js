function attachEventsListeners(){
    let inputDays = document.getElementById('days');
    let inputHours = document.getElementById('hours');;
    let inputMinutes = document.getElementById('minutes');;
    let inputSeconds = document.getElementById('seconds');

    document.getElementById('daysBtn')
    .addEventListener('click', calculateDays);

    document.getElementById('hoursBtn')
    .addEventListener('click', calculateHours);

    document.getElementById('minutesBtn')
    .addEventListener('click', calculateMinutes);
    
    document.getElementById('secondsBtn')
    .addEventListener('click', calculateSeconds);


    function calculateDays(){
        let days = Number(inputDays.value);
        let hours = days * 24;
        let minutes = hours * 60;
        let seconds = minutes * 60;
        inputHours.value = hours;
        inputMinutes.value = minutes;
        inputSeconds.value = seconds;
    }
    function calculateHours(){
        let hours = Number(inputHours.value);
        let days = hours / 24;
        let minutes = hours * 60;
        let seconds = minutes * 60;
        inputDays.value = days;
        inputMinutes.value = minutes;
        inputSeconds.value = seconds;
    }
    function calculateMinutes(){
        let minutes = Number(inputMinutes.value);
        let hours = minutes / 60;
        let seconds = minutes * 60;
        let days = minutes / 60 / 24;
        inputDays.value = days;
        inputHours.value = hours;
        inputSeconds.value = seconds; 
    }
    function calculateSeconds(){
        let seconds = Number(inputSeconds.value);
        let days = seconds / 60 / 24;
        let hours = seconds / 60/60;
        let minutes = seconds/ 60;
        inputDays.value = days;
        inputHours.value = hours;
        inputMinutes.value = minutes;
    }

}