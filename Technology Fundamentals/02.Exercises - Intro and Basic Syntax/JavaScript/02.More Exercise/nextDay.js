function nextDay(year, month, day){
    /*
    algorithm
    // 2004 6 15
    if (month === 12 && day === 30 || day === 31)
        year++;
        month = 1
        day = 1
    if (day === 30 || 31)
        month++;
        day = 1
    else
        day++;
    */
    let specialCase = year === 1 && month === 1 && day === 1;
    if((month === 12) && hasEndOfMonth(day)){
        year++;
        month = 1;
        day = 1;
    }

    if(hasEndOfMonth(day)){
        month++;
        day = 1;
    }else{
        day++;
    }
    //special case
    if (specialCase){
        console.log(`190${year}-${month}-${day}`);
    }else{
        console.log(`${year}-${month}-${day}`);
    }

    function hasEndOfMonth(day){
        return day === 30 || day === 31;
    }
}
nextDay(1,1,1);
nextDay(2016,9,30);
nextDay(2019,1,25);
