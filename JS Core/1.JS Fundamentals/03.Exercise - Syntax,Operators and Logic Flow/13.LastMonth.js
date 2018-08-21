function lastMonth(input){
    let day = input[0];
    let month = input[1];
    let year = input[2];

    [day, month, year] = [day,month, year].map(Number);
    let date = new Date(year, month - 1, 0);
    let days = date.getDate();

    console.log(days);
}