class List {
  constructor() {
    this.data = [];
    this.size = 0;
  }

  add(value) {
    this.size++;
    this.data.push(value);
    this.sortData();
  }

  remove(index) {
    if (this.isRange(index)) {
      this.size--;
      this.data.splice(index, 1);
      this.sortData();
    }
  }

  isRange(index) {
    const result = index >= 0 && index <= this.data.length - 1;
    return result;
  }

  get(index) {
    if (this.isRange(index)) {
      return this.data[index];
    }
  }

  sortData() {
    this.data.sort((a, b) => {
      return a - b;
    });
  }
}

let list = new List();
list.add(5);
list.add(3);
console.log(list.get(0));
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));
console.log(list.size);
