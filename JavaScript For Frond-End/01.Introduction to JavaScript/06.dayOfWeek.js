function dayOfWeek(day) {
    let days = {
        Monday : 1,
        Tuesday: 2,
        Wednesday: 3,
        Thursday: 4,
        Friday: 5,
        Saturday: 6,
        Sunday: 7
    };

    let currentDay = days[day];

    if (currentDay === undefined) {
        console.log('error');
    } else {
        console.log(currentDay);
    }
}

dayOfWeek('Monday');
dayOfWeek('Friday');