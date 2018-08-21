(function arrrayExtension() {
    Array.prototype.last = function(){
        return this[this.length - 1];
    }
    Array.prototype.skip = function(n){
        let output = [];
        for(let i = n; i<this.length;i++) {
            output.push(this[i]);
        }
        return output;
    }
    Array.prototype.take = function(n){
        let output = [];
        for(let i = 0; i<n;i++) {
            output.push(this[i]);
        }
        return output;
    }
    Array.prototype.sum = function(){
       let sum = this.reduce((a,b) => a + b);
       return sum;
    }
    Array.prototype.average = function(){
        let output = [];
        let sum = this.sum();
        return sum / this.length;
    }
})();
let arr = [1,2,3];
console.log(arr.last());
console.log(arr.skip(1));
console.log(arr.take(1));
console.log(arr.sum());
console.log(arr.average());