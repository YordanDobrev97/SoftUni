class Rat{
    constructor(name){
        this.name = name;
        this.objects = [];
    }
    unite(otherRat){
        if(otherRat.constructor === Rat){
            this.objects.push(otherRat);
        }
    }
    getRats(){
        return this.objects;
    }
    toString() {
        let output = `${this.name}\n`;
        for(let item of this.objects)
        {
            output +=`##${item.name}\n`;
        }
        return output;
    }
}
let pesho = new Rat('Pesho');
console.log(pesho.toString());

pesho.unite(new Rat('Gosho'));
console.log(pesho.toString());
pesho.unite(new Rat('Mariq'));
console.log(pesho.toString());