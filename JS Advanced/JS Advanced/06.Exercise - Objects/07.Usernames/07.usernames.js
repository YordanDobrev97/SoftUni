function solve(input) {
    const result = [];

    for(let name of input) {
        if (!result.includes(name)) {
            result.push(name);
        }
    }

   result.sort((a,b) => {
       if (a.length === b.length) {
          return a.localeCompare(b);
       }
       return a.length - b.length;
   });

   console.log(result.join('\n'));
}
solve(['Ashton',
'Kutcher',
'Ariel',
'Lilly',
'Keyden',
'Aizen',
'Billy',
'Braston']
);