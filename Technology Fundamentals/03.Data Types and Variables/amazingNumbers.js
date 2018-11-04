function solve(number){
   let convertToString = number.toString();

   let sum = 0;
   for (let index = 0; index < convertToString.length; index++) {
       const element = convertToString[index];
       sum += parseInt(element);
   }
   convertToString = sum.toString();

   let contains = convertToString.includes('9');
   
   if(contains){
     console.log(`${number} Amazing? True`);
   }else{
    console.log(`${number} Amazing? False`);
   }
}
solve(1233);
solve(583472);
solve(999);