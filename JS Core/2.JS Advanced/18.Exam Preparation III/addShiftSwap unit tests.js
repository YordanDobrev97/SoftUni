let expect = require('chai').expect;
function createList() {
    let data = [];
    return {
        add: function (item) {
            data.push(item)
        },
        shiftLeft: function () {
            if (data.length > 1) {
                let first = data.shift();
                data.push(first);
            }
        },
        shiftRight: function () {
            if (data.length > 1) {
                let last = data.pop();
                data.unshift(last);
            }
        },
        swap: function (index1, index2) {
            if (!Number.isInteger(index1) || index1 < 0 || index1 >= data.length ||
                !Number.isInteger(index2) || index2 < 0 || index2 >= data.length ||
                index1 === index2) {
                return false;
            }
            let temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
            return true;
        },
        toString: function () {
            return data.join(", ");
        }
    };
}
describe('Manipulations array tests', function () {
    let list;
    beforeEach(() => {
        list = createList();
    });
    describe('add items', function(){
        it('add items correctly', function(){
            list.add(1);
            list.add('two');
            list.add(3);
            expect(list.toString()).to.equal('1, two, 3');
        });
    })
    describe('shift-left items', function(){
        it('shift-left items correctly', function(){
            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);
            list.shiftLeft();
            expect(list.toString()).to.equal("2, 3, 4, 1");
        });
        it('shift-left items not correctly', function(){
            list.add(1);
            expect(list.toString()).to.equal('1');
        })
        it('shift-left items not correctly with 0 items', function(){
            expect(list.toString()).to.equal('');
        })
    });
    describe('shift-rigth items', function(){
        it('shift-rigth items correctly', function(){
            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);
            list.shiftRight();
            expect(list.toString()).to.equal("4, 1, 2, 3");
        });
        it('shift-left items not correctly', function(){
            list.add(1);
            list.shiftRight();
            expect(list.toString()).to.equal("1");
        });
        it('shift-left items not correctly with 0 items', function(){
            list.shiftRight();
            expect(list.toString()).to.equal("");
        })
    });
    describe('swap items', function(){
        it('swap items correctly', function(){
            list.add(1);
            list.add(2);
            list.swap(0, 1);
            expect(list.toString()).to.equal("2, 1");
        });
        it('swap items not correctly', function(){
            list.add(1);
            list.add(2);
            list.add('Pesho');
            list.add('Gosho');
            expect(list.swap('Pesho', 3)).to.equal(false);
            expect(list.swap(-1, 3)).to.equal(false);
            expect(list.swap(10, 3)).to.equal(false);

            expect(list.swap(1, 'Gosho')).to.equal(false);
            expect(list.swap(1, -1)).to.equal(false);
            expect(list.swap(1, 10)).to.equal(false);
        });
        it('not swap with one item', function(){
            list.add(1);
            expect(list.swap(0, 1)).to.equal(false);
        });
        it('not swap with 0 index item', function(){
            list.add(1);
            list.add(2);
            expect(list.swap(0, 1)).to.equal(false);
            expect(list.swap(1, 0)).to.equal(false);
        });
    });
    describe('toString items', function(){
        it('toString items correctly', function(){
            list.add(1);
            list.add(2);
            expect(list.toString()).to.equal("1, 2");
        });
        it('toString items correctly', function(){
            expect(list.toString()).to.equal("");
        });
    });
});