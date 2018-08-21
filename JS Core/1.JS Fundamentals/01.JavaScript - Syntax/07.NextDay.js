function calcNexDay(year, month, day){
    let data = new Date(year, month-1, day);
    let oneDay = 24 * 60 * 60 * 1000;
    let nextDay = new Date(data.getTime() + oneDay);

    return nextDay.getFullYear() + "-" + (nextDay.getMonth()+ 1) + "-" +
     nextDay.getDate();
}