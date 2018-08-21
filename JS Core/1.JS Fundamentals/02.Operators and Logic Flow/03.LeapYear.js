function leapYear(year){
    let isDivide4 = year % 4 == 0;
    let isNotDivide100 = year % 100 != 0;
    let isDivie400 = year % 400 == 0;

    let result = (isDivide4 && isNotDivide100) || isDivie400 ? "yes" : "no";

    console.log(result);
}