function timeWalk(argument1, argument2, argument3) {
    let studentSteps = Number(argument1);
    let meters = Number(argument2);
    let speed = Number(argument3);

    let distanceWakingMeters = studentSteps * meters;
    let speedMeters = speed / 3.6;
    let time = distanceWakingMeters / speedMeters;
    let rest = Math.floor(distanceWakingMeters / 500);

    let minutes = Math.floor(time / 60);
    let seconds = Math.round(time - (minutes * 60));
    let hours = Math.floor(time / 3600);

    console.log((hours < 10 ? "0" : "") + hours + ":" + (minutes + rest < 10 ? "0" : "") 
    + (minutes + rest) + ":" + (seconds < 10 ? "0" : "") + seconds);
}

timeWalk(4000, 0.60, 5);
