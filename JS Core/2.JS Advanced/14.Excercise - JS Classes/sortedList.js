class SortList{
    constructor(){
        this.listArray = [];
        this.size = 0;
    }
    add(element){
        this.listArray.push(element);
        this.size++;
       return this.listArray;
    }
    remove(index){
        if(index >=0 && index < this.listArray.length){
            this.listArray.slice(index, 1);
            this.size--;
        }
        return this.listArray;
    };
    get(index){
        if(index >= 0 && index < this.listArray.length){
            return this.listArray[index];
        }
    }
}
let list = new SortList();
list.add(1);
list.add(2);
list.add(3);
list.add(4);

console.log(list);// 1 2 3 4
console.log(list.get(0)); //1
list.remove(0); // remove 1
console.log(list); // 2 3 4