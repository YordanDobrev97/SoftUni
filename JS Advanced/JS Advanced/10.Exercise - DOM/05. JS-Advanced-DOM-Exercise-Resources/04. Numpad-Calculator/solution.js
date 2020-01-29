function solve() {
  const expressionOperators = ['+', '-', '*', '/'];

  const buttons = document.getElementsByClassName('keys')[0].children;
  const expressionOutput = document.getElementById('expressionOutput');
  const resultOutput = document.getElementById('resultOutput');
  const clearButton = document.getElementsByClassName('clear')[0];

  console.log(clearButton);
  Array.from(buttons).map(button =>
    button.addEventListener('click', (e) => {
      const value = e.target.value;
      
      let separator = '';
      if (expressionOperators.some(x => x === value)) {
        separator = ' ';
      }
      if (value === '=') {
         const resultExpression = calculateExpression();
         resultOutput.innerHTML = resultExpression;
      } else {
        expressionOutput.innerHTML += `${separator}${value}${separator}`;
      }
    })
  );

  clearButton.addEventListener('click', () => {
     expressionOutput.innerHTML = '';
     resultOutput.innerHTML = '';
  })

  function calculateExpression() {
     const items = expressionOutput.innerHTML.split(' ').filter(x => x !== '');
     const firstNumber = +items[0];
     const operator = items[1];
     const secondNumber = +items[2];
    
     const exprsObj = {
       '+':  firstNumber + secondNumber,
       '-':  firstNumber - secondNumber,
       '*':  firstNumber * secondNumber,
       '/': firstNumber / secondNumber
     }
     let result = exprsObj[operator];
     return result;
  }
}
