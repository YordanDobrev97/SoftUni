function distinctArray(array){

    function onlyUnique(value, index,self){
        return self.indexOf(value) === index;
    }

    let unique = array.filter(onlyUnique);

    console.log(unique.join(' '));
}
distinctArray([20, 8, 12, 13, 4,4, 8, 5]);//20 8 12 13 4 5