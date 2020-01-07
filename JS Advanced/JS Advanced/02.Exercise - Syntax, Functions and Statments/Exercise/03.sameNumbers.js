function sameNumber(number) {

   function sumOfDigitNumber(number) {
       let valueNumber = number;
       let sum = 0;

       while (valueNumber > 0) {
          let lastDigit = valueNumber % 10;
          sum += lastDigit;
          valueNumber = Math.floor(valueNumber / 10);
       }
       return sum;
   }

   function isEqualDigits(number) {
      let firstDigit = +number.toString()[0];
      let lastDigit = number % 10;

      return firstDigit === lastDigit;
   }

   let sumDigits = sumOfDigitNumber(number);
   let isEqualDigitsNumber = isEqualDigits(number);
   
   console.log(isEqualDigitsNumber);
   console.log(sumDigits);
}

sameNumber(22222);
