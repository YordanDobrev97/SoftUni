function sortArray(){
    let result = (function(){
        let listArray = [];
        let size = 0;

        let add = function(element){
            listArray.push(element);
            size++;
            return listArray;
        };
        let remove = function(index){
            if(index >=0 && index < listArray.length){
                listArray.slice(index, 1);
                size--;
            }
            return listArray;
        };
        let get = function(index){
            if(index >= 0 && index < listArray.length){
                return listArray[index];
            }
        }
        return {add,remove,get};
    })();
}