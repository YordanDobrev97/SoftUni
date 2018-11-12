function dayOfWeek(day){
    let days = [
        'Monday',
        'Tuesday',
        'Wednesday',
        'Thursday',
        'Friday',
        'Saturday',
        'Sunday'
    ];

    if(day < 0 || day > 7){
        console.log('Invalid day!');
    }else{
        console.log(days[day - 1]);
    }
}
dayOfWeek(5);