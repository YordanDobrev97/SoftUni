function bombNumbers(sequence, bombNumbers){
    let detontaionNumber = bombNumbers.shift();
    let power = bombNumbers.shift();

    let indexNumber = 0;
    while(sequence.includes(detontaionNumber)){
        indexNumber = sequence.indexOf(detontaionNumber);
        let endLeft = indexNumber - power;
        let endRight = indexNumber + power;
        removeLeft(indexNumber,endLeft);
        removeRigth(indexNumber,endRight);

        sequence[indexNumber] = undefined;
    
        function removeLeft(index,end){
            for(let i = indexNumber - 1; i>=end;i--){
                sequence[i] = undefined;
            }
        }

        function removeRigth(index, end){
            for(let i = index + 1; i <=end; i++){
                sequence[i] = undefined;
            }
        }
    }

    sequence = sequence.filter(el => el !== undefined);
    let result = sum(sequence);
    console.log(result);

    function sum(nums){
        let sum = 0;
        for(let item of nums)
        {
            sum += item;
        }

        return sum;
    }
}
bombNumbers([5,6,3,8,1], [10,1]);
bombNumbers([1, 1, 2, 1, 1, 1, 2, 1, 1, 1],[2, 1]);
bombNumbers([1,2,2,4,2,2,2,9], [4,2]);
bombNumbers([1, 4, 4, 2, 8, 9, 1],[9, 3]);
bombNumbers([1, 7, 7, 1, 2, 3],[7, 1]);
