function smallestNumbers(array) {
   let sortedArray = array.sort((a,b) => a - b);
   let firstSmallestNumber = sortedArray.shift();
   let secondSmallestNumber = sortedArray.shift();

   console.log(`${firstSmallestNumber} ${secondSmallestNumber}`);
}

smallestNumbers([30, 15, 50, 5]);