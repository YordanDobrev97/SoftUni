function greatesCommonDivisor(firstNumber, secondNumber) {
      let biggest = Math.max(firstNumber, secondNumber);
      let smallest = Math.min(firstNumber, secondNumber);

      while (true) {
          let remainder = biggest % smallest;
          if (remainder === 0) {
              break;
          }

          biggest = smallest;
          smallest = remainder;
          biggest = Math.max(biggest, smallest);
          smallest = Math.min(biggest, smallest);

      }
      console.log(smallest);
}

greatesCommonDivisor(2154, 458);
