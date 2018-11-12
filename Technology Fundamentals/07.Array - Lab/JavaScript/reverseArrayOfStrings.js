function reverseStringArray(array){

    for (let index = 0; index < array.length / 2; index++) {
         swap(index, array.length - 1 - index, array);
    };

    console.log(array.join(' '));

    function swap(frontIndex, behindIndex, array){
        let temp = array[frontIndex];
        array[frontIndex] = array[behindIndex];
        array[behindIndex] = temp;
    }
}
reverseStringArray(['A', 'B', 'C', 'D']);//D C B A