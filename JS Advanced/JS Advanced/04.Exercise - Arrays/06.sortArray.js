function sortArray(array) {
   let sorted = array.sort((a, b) => {
        if (a.length === b.length) {
           if (a < b) {
             return -1;
           }
           return 1;
        }
        return a.length - b.length;
   });

   console.log(sorted.join('\n'));
}

sortArray(['alpha',
'beta',
'gamma']);
