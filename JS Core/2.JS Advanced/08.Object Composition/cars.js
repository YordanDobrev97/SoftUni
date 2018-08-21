function cars(array){
    let result = {};
    let processCars = (function(){
        function create(parameter){
            if(parameter.length == 2){
                // create without inherence
                result[parameter] = {};
            }else{
                let items = parameter.split(' ');
                result[items[1]] = {};
                result[items[1]] = Object.create(result[items[3]]);
            }
        }
        function set(parameter){
            let items = parameter.split(' ');
            let parent = items[1];
            let key = items[2];
            let value = items[3];

            result[parent][key] = value;
        }
        function print(value){
            let resultArray = []; 
            let objValues = result[value];

            for(let item in objValues)
            {
                resultArray.push(`${item}:${objValues[item]}`);
            }
            console.log(resultArray.join(', '));
        }
        return {create, set,print};
    })();

    for(let item of array)
    {
       if(item.split(' ').length == 2){
         let [command, value] = item.split(' ');
         processCars[command](value);
       }else{
           let [command1, value, command2, parentName] = item.split(' ');
           processCars[command1](item);
       }
    }   
}
cars(['create c1','create c2 inherit c1',
'set c1 color red',
'set c2 model new',
'print c1',
'print c2'
]);