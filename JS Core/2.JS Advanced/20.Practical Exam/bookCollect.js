class BookCollection {
    constructor(shelfGenre, room, capacity){
        this.books = [];
        this.room = room;
        this.shelfGenre = shelfGenre;
        this.capacity = capacity;
        this.bookName;
        this.bookAuthor;
        this.genre;
    }
    addBook(bookName, bookAuthor, genre){
        if(this.capacity !== undefined && this.books.length < this.capacity){
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.genre = genre;
            this.books.push(`${this.bookName} - ${this.bookAuthor} ${this.genre}`);
        }else{
            this.books.shift();
        }
        //let sort = this.books.sort((a,b) => a = this.bookName < b = this.bo);
    }
    throwAwayBook(bookName) {
        return this.books.filter((b => b.includes(bookName)));
    }
    showBooks(genre){
        let result = `Results for search "${genre}":\n`;
        for(let item of this.books)
        {
            if(item.includes(genre)){
                result += `  ${item}\n`;
            }
        }
        return result;
    }
    set room(roomInput){
        if(roomInput === 'livingRoom' || roomInput === 'bedRoom' || roomInput === 'closet'){

        }else{
            throw new Error(`Cannot have book shelf in ${roomInput}`);
        }
    }
    toString(){
        let result = `${this.shelfGenre} shelf in ${this.room} contains:\n`;

        for(let item of this.books)
        {
            result += `  ${item}\n`;
        }

        return result;
    }
}
let bedRoom = new BookCollection('Mixed', 'bedRoom', 5);
bedRoom.addBook("John Adams", "David McCullough", "history");
bedRoom.addBook("John Adams", "Cuentos para pensar", "history");
bedRoom.throwAwayBook('ik');
console.log("Shelf's capacity: " + bedRoom.shelfCondition);
console.log(bedRoom.showBooks("history"));


// let livingRoom = new BookCollection("Programming", "livingRoom", 5);
// livingRoom.addBook("B Introduction to Programming with C#", "Svetlin Nakov")
// livingRoom.addBook("A Introduction to Programming with Java", "Svetlin Nakov")
// livingRoom.addBook("Programming for .NET Framework", "Svetlin Nakov");
// livingRoom.addBook("B Introduction to Programming with C#", "Svetlin Nakov")
// livingRoom.addBook("A Introduction to Programming with Java", "Svetlin Nakov")
// livingRoom.addBook("Programming for .NET Framework", "Svetlin Nakov");
// console.log(livingRoom.toString());


//let garden = new BookCollection("Programming", "garden");
