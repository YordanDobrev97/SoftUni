function modificationNumber(array) {
    function modification(array) {
      let initialNumber = 1;

      let commands = {
        'add': function add(collection) {
            collection.push(initialNumber);
        },
        'remove': function removeLast(collection) {
              collection.pop();
        }
      };

      let newArray = [];
      for (let command of array) {
          let operationCommand = commands[command];
          operationCommand(newArray);
          initialNumber++;
      }

      if (newArray.length === 0) {
          console.log('Empty');
      } else {
          console.log(newArray.join('\n'));
      }
    };
    modification(array);
}

modificationNumber([
    'add', 'add', 'remove', 'add', 'add'
]);
