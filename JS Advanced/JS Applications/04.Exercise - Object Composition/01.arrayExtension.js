(function extendArray() {
    Array.prototype.last = function() {
        return this[this.length - 1];
    }
    Array.prototype.skip = function(count) {
        const newArray = [];
        for (let i = count; i < this.length; i++) {
           newArray.push(this[i]);
        }
        return newArray;
    }
    Array.prototype.take = function(count) {
        const newArray = [];
        for (let i = 0; i < count; i++) {
            newArray.push(this[i]);
        }
        return newArray;
    }
    Array.prototype.sum = function() {
        return this.reduce((prev, current) => prev + current, 0);
    }
    Array.prototype.average = function() {
        const sum = this.sum();
        return sum / this.length;
    }
})();

const arr = [1,2,3,4,5,6,7,8,9,10];
console.log(arr.last());
console.log(arr.skip(5).join(','));
console.log(arr.take(4).join(' '));
console.log(arr.sum());
console.log(arr.average());

