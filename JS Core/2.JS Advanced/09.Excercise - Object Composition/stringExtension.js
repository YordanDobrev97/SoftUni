(function(){
    String.prototype.ensureStart = function(str){
        if(!this.toString().startsWith(str)){
           return str + this.toString();
        }
        return this.toString();
    }
    String.prototype.ensureEnd = function(str){
        if(!this.toString().endsWith(str)){
            return this.toString() + str;
        }
        return this.toString();
    }
    String.prototype.isEmpty = function(){
        return this.toString().localeCompare("") == 0;
    }
    String.prototype.truncate = function(n){
        if(n <= 3){
            return ".".repeat(n);
        }
        if(this.toString() <= n){
            return this.toString();
        }
        let lastIndex = this.toString().substr(0, n - 2).lastIndexOf(' ');
        if(lastIndex != -1){
            return this.toString().substr(0, lastIndex) + '...';
        }else{
            return this.toString().substr(0, n - 3) + '...';
        }
    }
    String.format = function(str, ...params){
        for(let i = 0; i<params.length;i++) {
            let index = str.indexOf('{' + i + '}');
            while (index != -1) {
                str = str.replace('{' + i + '}', params[i]);
                index = str.indexOf('{' + i + '}');
            } 
        }
    }

})();
let str = 'my string'
console.log(str = str.ensureStart('my'));
console.log(str = str.ensureStart('hello '));
console.log(str = str.truncate(16) );
console.log(str = str.truncate(14));
console.log(str = str.truncate(8));
console.log(str = str.truncate(4));
console.log(str = str.truncate(2));
console.log(str = String.format('The {0} {1} fox',
'quick', 'brown'));
console.log(str = String.format('jumps {0} {1}','dog'));

