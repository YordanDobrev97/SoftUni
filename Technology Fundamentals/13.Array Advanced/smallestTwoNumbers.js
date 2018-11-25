function smallestTwoNums(array){
    let sort = array.sort((a,b) => a - b)
    sort = sort.slice(0,2);

    console.log(sort.join(' '));
}
smallestTwoNums([30, 15, 50, 5]);