function captureNums(input){
    let nums = [];
    let regex = /\d+/gm;
    for(let item of input)
    {
        let match = regex.exec(item);
        while(match){
            nums.push(match);
            match = regex.exec(item);
        }
    }
    console.log(nums.join(' '));
}