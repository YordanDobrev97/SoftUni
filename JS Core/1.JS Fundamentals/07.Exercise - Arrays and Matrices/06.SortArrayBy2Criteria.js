function sortArray(array){
    array = array.sort()
    .sort((item1,item2) => item1.length - item2.length)
    .forEach(element => {
       console.log(element);
    });
}