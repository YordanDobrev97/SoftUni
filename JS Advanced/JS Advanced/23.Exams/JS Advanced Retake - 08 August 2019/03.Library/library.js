class Library {
  constructor(libraryName) {
    this.libraryName = libraryName;
    this.subscribers = [];
    this.subscriptionTypes = {
      normal: this.libraryName.length,
      special: this.libraryName.length * 2,
      vip: Number.MAX_SAFE_INTEGER
    };
  }

  subscribe(name, type) {
    const validTypes = ['normal', 'special', 'vip'];

    if (!validTypes.includes(type)) {
      throw new TypeError(`The type ${type} is invalid`);
    }

    const subscribeObj = {
        name: name,
        type: type,
        books: []
    };

    if (!this.subscribers.some(x => x.name === name)) {
        this.subscribers.push(subscribeObj);
    } else {
        const index = this.subscribers.findIndex(x => x.name === name);
        this.subscribers[index].type = type;
    }

    return subscribeObj;
  }

  unsubscribe(name) {
      if (!this.subscribers.some(x => x.name === name)) {
         throw new Error(`There is no such subscriber as ${name}`);
      }

      const index = this.subscribers.findIndex(x => x.name === name);
      this.subscribers.splice(index, 1);

      return this.subscribers;
  }

  receiveBook(subscriberName, bookTitle, bookAuthor) {
    if (!this.subscribers.some(x => x.name === subscriberName)) {
        throw new Error(`There is no such subscriber as ${name}`);
    }

    const index = this.subscribers.findIndex(x => x.name === subscriberName);
    const typeBook = this.subscribers[index].type;
    const limitType = this.subscriptionTypes[typeBook];

    if (this.subscribers.length + 1 >= limitType) {
        throw new Error(`You have reached your subscription limit ${limitType}!`);
    }

    const currentBook = this.subscribers[index].books;
    currentBook.push({
        title: bookTitle,
        author: bookAuthor
    });
  }

  showInfo() {
    if (this.subscribers.length === 0) {
        return `${this.libraryName} has no information about any subscribers`;
    }

    let output = '';

    for(let item of this.subscribers) {
        output += `Subscriber: ${item.name}, Type: ${item.type}\n`;
        let books = `Received books:`;
        const countBooks = item.books.length - 1;
        let currentCountBook = 1;
        item.books.forEach(book => {
            if (countBooks >= currentCountBook) {
                books += ` ${book.title} by ${book.author}, `   
            } else {
                books += `${book.title} by ${book.author}`
            }

            currentCountBook++;
        });

        output += `${books}\n`;
    }

    return output;
  }
}

let lib = new Library('L');

lib.subscribe('Peter', 'normal');
lib.subscribe('John', 'special');
lib.subscribe('Josh','vip')

lib.receiveBook('John', 'A Song of Ice and Fire', 'George R. R. Martin');
lib.receiveBook('John', 'Harry Potter', 'J. K. Rowling');
lib.receiveBook('Josh', 'Graf Monte Cristo', 'Alexandre Dumas');
lib.receiveBook('Josh','Cromwell','Victor Hugo');
lib.receiveBook('Josh','Marie Tudor','Victor Hugo');
lib.receiveBook('Josh','Bug-Jargal','Victor Hugo');
lib.receiveBook('Josh','Les Orientales','Victor Hugo');
lib.receiveBook('Josh','Marion de Lorme','Victor Hugo');
lib.receiveBook('Peter', 'Lord of the rings', 'J. R. R. Tolkien');