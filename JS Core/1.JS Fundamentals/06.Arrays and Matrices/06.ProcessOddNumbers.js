function nums(arr){
    let arrResult = [];
	
	for(let index in arr){
		if(index % 2 == 1){
			arrResult.push(arr[index] * 2);
		}
	}
	let reversedArr = arrResult.reverse();
	console.log(reversedArr.join(" "));
}