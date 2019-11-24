function getPrice(dayOfWeek, service, time){
    let timeToString = '' + time;
    let timeElements = timeToString.split('.');
    let hour = Number(timeElements[0]);
    let minutes = Number(timeElements[1]);

    let price = 0;
    if (dayOfWeek === 'Monday') {   
        if (service === 'Fitness') {
            if (BeforeEvening()) {
                price = 5;
            } else {
                price = 7.50;
            }
        } else if (service === 'Sauna') {
            if (BeforeEvening()) {
                price = 4;
            } else {
                price = 6.50;
            }
        } else if (service === 'Instructor') {
            if (BeforeEvening()) {
                price = 10;
            }else {
                price = 12.50;
            }
        }
    }

    console.log(price);
    

    function BeforeEvening() {
        return hour < 15 || hour === 15 && minutes === 0;
    }
}
getPrice('Monday', 'Fitness', 15.10);
