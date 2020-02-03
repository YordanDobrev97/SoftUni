class Rat {
    constructor(name) {
       this.name = name;
       this.rats = [];
    }

    unite(rat) {
       const ratInstance = rat instanceof Rat;
       if (ratInstance) {
          this.rats.push(rat);
       }
    }

    getRats() {
        return this.rats;
    }

    toString() {
        let result = `${this.name}\n`;

        for(let item of this.rats) {
            result += `##${item}\n`;
        }
        return result;
    }
}

let firstRat = new Rat("Peter");
console.log(firstRat.toString()); // Peter
 
console.log(firstRat.getRats()); // []

const secondRat = new Rat("George");
firstRat.unite(secondRat);
firstRat.unite(new Rat("Alex"));
console.log(firstRat.getRats());
// [ Rat { name: 'George', unitedRats: [] },
//  Rat { name: 'Alex', unitedRats: [] } ]

console.log(firstRat.toString());
// Peter
// ##George
// ##Alex
