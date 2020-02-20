const expect = require("chai").expect;
const BookStore = require("./02.Book-Store");

describe("test BookStore", () => {
  it("test constructor", () => {
    const bookStore = new BookStore("Store");
    expect(bookStore.name).to.be.equal("Store");
  });

  it("test stockBooks() function", () => {
    const bookStore = new BookStore("Store");
    const books = bookStore.stockBooks([
      "Inferno-Dan Braun",
      "Harry Potter-J.Rowling",
      "Uncle Toms Cabin-Hariet Stow",
      "The Jungle-Upton Sinclear"
    ]);
    expect(books.length).to.be.equal(4);
  });

  it("test hire() function - return success result", () => {
    const bookStore = new BookStore("Store");
    bookStore.stockBooks([
      "Inferno-Dan Braun",
      "Harry Potter-J.Rowling",
      "Uncle Toms Cabin-Hariet Stow",
      "The Jungle-Upton Sinclear"
    ]);
    const hireBook = bookStore.hire("George", "seller");
    expect(hireBook).to.be.equal("George started work at Store as seller");
  });

  it("test hire() function - return This person is our employee", () => {
    const bookStore = new BookStore("Store");
    const books = bookStore.stockBooks([
      "Inferno-Dan Braun",
      "Harry Potter-J.Rowling",
      "Uncle Toms Cabin-Hariet Stow",
      "The Jungle-Upton Sinclear"
    ]);
    bookStore.hire("George", "seller");
    const hireBook = () => {
      bookStore.hire("George", "seller");
    };
    expect(hireBook).to.throw("This person is our employee");
  });

  it("test fire() function", () => {
    const bookStore = new BookStore("Store");
    bookStore.stockBooks([
      "Inferno-Dan Braun",
      "Harry Potter-J.Rowling",
      "Uncle Toms Cabin-Hariet Stow",
      "The Jungle-Upton Sinclear"
    ]);
    bookStore.hire("George", "seller");
    const fire = bookStore.fire("George");
    expect(fire).to.be.equal("George is fired");
  });

  it("test fire() function - return doesn't work here", () => {
    const bookStore = new BookStore("Store");
    const fire = () => {
      bookStore.fire("George");
    };
    expect(fire).to.throw("George doesn't work here");
  });

  it("test sellBook() function", () => {
    let store = new BookStore("Store");
    store.stockBooks([
      "Inferno-Dan Braun",
      "Harry Potter-J.Rowling",
      "Uncle Toms Cabin-Hariet Stow",
      "The Jungle-Upton Sinclear"
    ]);
    store.hire("Ina", "seller");
    const sellBook = store.sellBook("Inferno", "Ina");
    expect(sellBook).to.be.undefined;
  });

  it("test sellBook() function - return This book is out of stock", () => {
    let store = new BookStore("Store");
    store.stockBooks([
      "Inferno-Dan Braun",
      "Harry Potter-J.Rowling",
      "Uncle Toms Cabin-Hariet Stow",
      "The Jungle-Upton Sinclear"
    ]);
    const sellBook = () => {
      store.sellBook("Invalid", "Ina");
    };
    expect(sellBook).to.throw("This book is out of stock");
  });

  it("test sellBook() function - return {workerName} is not working here", () => {
    let store = new BookStore("Store");
    store.stockBooks([
      "Inferno-Dan Braun",
      "Harry Potter-J.Rowling",
      "Uncle Toms Cabin-Hariet Stow",
      "The Jungle-Upton Sinclear"
    ]);
    const sellBook = () => {
      store.sellBook("Inferno", "Pesho");
    };
    expect(sellBook).to.throw("Pesho is not working here");
  });

  it("test  printWorkers() function", () => {
    let store = new BookStore("Store");

    store.stockBooks([
      "Inferno-Dan Braun",
      "Harry Potter-J.Rowling",
      "Uncle Toms Cabin-Hariet Stow",
      "The Jungle-Upton Sinclear"
    ]);

    store.hire("Ina", "seller");
    store.sellBook("Inferno", "Ina");
    const print = store.printWorkers();
    expect(print).to.be.equal('Name:Ina Position:seller BooksSold:1');
  });
});