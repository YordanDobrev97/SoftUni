function matchDates(dates){
    let regex = /\b(\d{1,2})-([A-Z][a-z]{2})-(\d{4})\b/g;
    let result;
    for(let item of dates)
    {
        while (result = regex.exec(item)){
            console.log(`${result[0]} (Day: ${result[1]}, Month: ${result[2]}, Year: ${result[3]})`);
        }
    }
}