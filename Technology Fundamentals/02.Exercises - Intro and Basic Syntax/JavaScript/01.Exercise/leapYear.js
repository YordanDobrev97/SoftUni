function solve(year){
    let isLearYear = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);

    if(isLearYear){
        console.log('yes');
    }else{
        console.log('no');
    }
}
solve(1984);
solve(2003);