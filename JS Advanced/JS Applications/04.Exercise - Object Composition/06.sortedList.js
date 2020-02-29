function SortedList() {
    return {
        data: [],
        size: 0,
        add: function(element) {
            this.data.push(element);
            this.data.sort((a,b) => a - b);
            this.size++;
        },
        remove: function(index) {
            if (index < 0 || index > this.data.length - 1) {
                throw new Error('Invalid index!')
            }

            this.data.splice(index, 1);
            this.size--;
        },
        get: function(index) {
            if (index < 0 || index > this.data.length - 1) {
                throw new Error('Invalid index!')
            }

            return this.data[index];
        }
    };
}

const list = new SortedList();
list.add(10);
console.log(list.get(0));