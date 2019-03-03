function solve(arrayOfCats) {
    let cats = [];
    class Cat {
        constructor(name, age) {
            this.name = name;
            this.age = age;
        }
    
        meow() {
            console.log(`${this.name}, age ${this.age} says Meow`);
        }
    }   

    for (let i = 0; i < arrayOfCats.length; i++) {
        const element = arrayOfCats[i].split(' ');
        let name = element[0];
        let age = element[1];

        let cat = new Cat(name, age);
        cats.push(cat);
    }

    for(let cat of cats) {
       cat.meow();
    }
}

solve(['Mellow 2', 'Tom 5']);