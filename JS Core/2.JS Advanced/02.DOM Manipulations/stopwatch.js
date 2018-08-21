function stopwatch(){
    let time;
    let intervalId;
    let buttonId = document.getElementById('startBtn');
    let stopBtnId = document.getElementById('stopBtn');

    let addEvent = buttonId.addEventListener('click', function() {
        time = -1;
        incrementTime();
        intervalId = setInterval(incrementTime, 1000);
        buttonId.disabled = true;
        stopBtnId.disabled = false;
    });
    let activateStopBtn = stopBtnId.addEventListener('click', function(){
        clearInterval(intervalId);
        buttonId.disabled = false;
        stopBtnId.disabled = true;
    });
    function incrementTime(){
        time++;
        let minutes = time / 60;
        let seconds = time % 60;
        document.getElementById('time').textContent = ('0' + 
        Math.trunc(minutes)).slice(-2) + ':' + ('0' 
        + Math.trunc(seconds)).slice(-2);
    }
}