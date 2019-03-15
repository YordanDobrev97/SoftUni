function equalSum(array) {
    let foundIndex = 0;

    let containsEqualSum = false;
    for (let index = 1; index < array.length; index++) {
        let getLeftSum = leftSum(index);
        let getRightSum = rightSum(index);

        if(getLeftSum === getRightSum){
            containsEqualSum = true;
            foundIndex =index;
            break;
        }
    }
    
    if(containsEqualSum || array.length === 1){
        console.log(foundIndex);
    }else{
        console.log('no');
    }

    function leftSum(index){
        let sum = 0;

        while(index != 0){
            index--;
            let element = array[index];
            sum += element;
        }
        return sum;
    }
    function rightSum(index){
        let sum = 0;

        let maxLength = array.length - 1;

        while(index < maxLength){
            index++;
            let element = array[index];
            sum += element;
        }
        return sum;
    }
}
equalSum([1,2,3,3]);
equalSum([1,2]);
equalSum([1]);
equalSum([10, 5, 5, 99, 3, 4, 2,5, 1, 1, 4])
