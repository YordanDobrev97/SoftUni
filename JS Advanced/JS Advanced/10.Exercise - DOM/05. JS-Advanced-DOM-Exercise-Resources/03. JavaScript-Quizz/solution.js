function solve() {
  const correctlyAnswers = ["onclick", "JSON.stringify()", "A programming API for HTML and XML documents"];

  let countCorrectlyAnswer = 0;
  let index = 0;

  let div = document.getElementsByTagName("p");
  const section = document.getElementsByTagName('section');
 
  let result = document.getElementById('results'); 
  Array.from(div).map(x =>
    x.addEventListener("click", () => {
      const userAnswer = x.innerHTML;

      if (correctlyAnswers.includes(userAnswer)) {
        countCorrectlyAnswer++;
      }
      section[index].style.display = 'none';

      index++;
      if (index <= correctlyAnswers.length - 1) {
         x = section[index];
         section[index].style.display = 'block';
      } else {
         result.style.display = 'block';

         if (countCorrectlyAnswer === correctlyAnswers.length) {
            result.children[0].children[0].innerHTML = `You are recognized as top JavaScript fan!`;
         } else {
            result.children[0].children[0].innerHTML = `You have ${countCorrectlyAnswer} right answers`;
         }
      }
    })
  );
}
