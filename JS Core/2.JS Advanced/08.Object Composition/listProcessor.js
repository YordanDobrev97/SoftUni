function process(array){
    let commandProcess = (function(){
        let result = [];
        function add(element){
            result.push(element);
        }
        function remove(element){
             result = result.filter(el => el !== element);
        }
         function print(){
             console.log(result.join(','));
        }
        return {add, remove, print};
    })();
    for(let item of array)
    {
       let [command, value] = item.split(' ');
       commandProcess[command](value);
    }
}
console.log(process(['add hello', 'add again', 'remove hello', 'add again', 'print']));
console.log(process(['add pesho', 'add gosho', 'add pesho', 'remove pesho','print']));