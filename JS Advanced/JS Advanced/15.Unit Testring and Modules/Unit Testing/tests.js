const expect = require('chai').expect;
const sum = require('./sum.js');
const isSymmetric = require('./checkForSymmetry.js');
const rgbToHexColor = require('./06.rgbToHex.js');
const createCalculator = require('./07.AddSubtract.js');

//04.Sum of Numbers
describe('test function sum', () => {
    it ('test with valid data', () => {
       expect(sum([1,2,3])).to.be.equal(6);
    });
    
    it ('test with invalid data', () => {
        expect(sum(['Pesho', 'Gosho', 'Ivan'])).to.be.NaN;
    });
    
    it ('test with empty array', () => {
        expect(sum([])).to.be.equal(0);
    });

});

//05.Check for Symmetry
describe('test function isSymmetric', () =>{
    it ('test with no array not symmetric ', () => {
        expect(isSymmetric('Pesho')).to.be.equal(false);
    });

    it ('test with correctly data - return true', () => {
        expect(isSymmetric(['ba', 'ba'])).to.be.equal(true);
    });

    it ('test with correctly data again - return true', () => {
        expect(isSymmetric(['ooo', 'ooo', 'ooo'])).to.be.equal(true);
    })

    it ('test with numeric data - return true', () => {
        expect(isSymmetric([1,2,3, 3, 2, 1])).to.be.equal(true);
    })

    it ('test with correctly data - return false', () => {
        expect(isSymmetric(['al', 'alo'])).to.be.equal(false);
    });

    it ('test with invalid data - return false', () => {
        expect(isSymmetric([{}, 123, 'name'])).to.be.equal(false);
    })

    it ('test with any data - return true', () => {
        expect(isSymmetric([{}, 'string', {}])).to.be.equal(true);
    })
});

//06.RGB To HexColor
describe('test rgbToHexColor function', () => {
    describe('test red color', () => {
        it ('test with invalid red color - not number', () => {
            expect(rgbToHexColor('Pesho')).to.be.undefined;
         });
    
         it ('test invalid red color - negative number', () => {
             expect(rgbToHexColor(-10, 12, 13)).to.be.undefined;
         });
    
         it ('test with invalid red color - invalid range value', () => {
             expect(rgbToHexColor(10000, 3, 5)).to.be.undefined;
         });

         it ('test with valid value - 255', () => {
             expect(rgbToHexColor(255, 10, 10)).to.be.equal('#FF0A0A');
         });

         it ('test with valid value - 0', () => {
            expect(rgbToHexColor(0, 10, 0)).to.be.equal('#000A00');
        });
         
         it ('test with correctly color values', () => {
             expect(rgbToHexColor(10, 21, 17)).to.be.equal('#0A1511');
         });
    });

    describe('test green color', () => {
        it ('test with not number', () => {
            expect(rgbToHexColor(10, 'Gosho', 13)).to.be.undefined;
        });

        it ('test with negative value', () => {
            expect(rgbToHexColor(10, -10, 3)).to.be.undefined;
        });

        it ('test with invalid range value', () => {
            expect(rgbToHexColor(10, 2000, 3)).to.be.undefined;
        });

        it ('test with valid value - 255', () => {
            expect(rgbToHexColor(10, 255, 10)).to.be.equal('#0AFF0A');
        });

        it ('test with valid value - 0', () => {
            expect(rgbToHexColor(10, 0, 10)).to.be.equal('#0A000A');
        });

        it ('test with correctly data', () => {
            expect(rgbToHexColor(10, 12, 14)).to.be.equal('#0A0C0E');
        });
    });

    describe('test blue color', () => {
        it ('test with not number', () => {
            expect(rgbToHexColor(10, 12, {})).to.be.undefined;
        });

        it ('test with negative value', () => {
            expect(rgbToHexColor(10, 10, -10)).to.be.undefined;
        });

        it ('test with invalid range value', ()  => {
            expect(rgbToHexColor(10, 10, 100000)).to.be.undefined;
        });

        it ('test with valid value - 255', () => {
            expect(rgbToHexColor(55, 10, 255)).to.be.equal('#370AFF');
        });

        it ('test with valid value - 0', () => {
            expect(rgbToHexColor(10, 12, 0)).to.be.equal('#0A0C00');
        })

        it ('test with correctly data', () => {
            expect(rgbToHexColor(20, 21, 22)).to.be.equal('#141516');
        });
    });
});

//07.Add/Subtract
describe('test createCalculator function', () => {
    let calculate;

    beforeEach(() => {
        calculate = createCalculator();
    })

    it ('test get function first', () => {
        expect(calculate.get()).to.be.equal(0);
    })

    it ('test add function - return correctly result', () => {
        calculate.add(10);
        calculate.add(15);
        expect(calculate.get()).to.be.equal(25);
    });

    it ('test add function with empty array', () => {
        calculate.add([]);
        expect(calculate.get()).to.be.equal(0);
    });

    it ('test add and subtract double values', () =>{
        calculate.add(10.50);
        calculate.subtract(10.50);
        expect(calculate.get()).to.be.equal(0);
    })

    it ('test subtract function with correctly data', () => {
        calculate.subtract(5);
        calculate.subtract(5);
        expect(calculate.get()).to.be.equal(-10);
    });

    it ('test add and subtract functions together', () => {
        calculate.add(5);
        calculate.subtract(10);
        expect(calculate.get()).to.be.equal(-5);
    });

    it ('test subtract function with string value', () => {
        calculate.subtract('Pesho');
        expect(calculate.get()).to.be.NaN;
    });
});