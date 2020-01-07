function operationsByNumber(array) {
      let number = Number(array.shift());

      let operationByNumberObj = {
          'chop': function diviedNumberByTwo(number) {
              return number / 2;
          },
          'dice': function squareRootNumber(number) {
              return Math.sqrt(number);
          },
          'spice': function incrementNumber(number) {
               return number + 1;
          },
          'bake': function multiplyBy3(number) {
              return number * 3;
          },
          'fillet': function subtractPercentage(number) {
              return number - (number * 0.20);
          }
      };

      for (let operation of array) {
           let curentOperation = operationByNumberObj[operation];
           number = curentOperation(number);
           console.log(number);
      }
}

operationsByNumber(
  ['9', 'dice', 'spice', 'chop', 'bake', 'fillet']
);
