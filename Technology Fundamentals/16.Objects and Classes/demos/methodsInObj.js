let obj = {
    printHello: function() {
        console.log('hello');
    }
}
obj.abstractMethod = () => console.log('I\'m abstract method');
obj.abstractMethod();
console.log(obj);