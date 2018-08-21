function cloneObjcets(){
    let obj = {
        extend: function(template){
            for(let item of Object.keys(template)){
                if(typeof template[item] == 'function'){
                    Object.getPrototypeOf(obj)[item] = template[item];
                }else{
                    obj[item] = template[item];
                }
            }
        }
    }
    return obj;
}