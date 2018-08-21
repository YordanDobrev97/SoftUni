let result = (function (){
   let counter = 0;
   return class Extensible{
        constructor(){
            this.id = counter;
            counter++;
        }
        extend(template){
            for(let item of Object.keys(template)){
                if(typeof template[item] == 'function'){
                    Object.getPrototypeOf(obj)[item] = template[item];
                }else{
                    obj[item] = template[item];
                }
            }
        }
    }
})();
