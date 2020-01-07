function convertArrayToObject(array) {
   let foods = array.filter((el, index) =>  {
      return index % 2 === 0
   });

   let calories = array.filter((el, index) => {
      return index % 2 === 1;
   });

   let resultObject = {};
   for (let i =0; i < foods.length; i++) {
     let currentFood = foods[i];
     let calorie = Number(calories[i]);
     resultObject[currentFood] = calorie;
   }

   console.log(resultObject);
}
convertArrayToObject([
  'Potato', 93,
  'Skyr', 63,
  'Cucumber', 18
]);
