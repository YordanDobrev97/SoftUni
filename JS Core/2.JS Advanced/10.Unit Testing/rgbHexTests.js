let expect = require('chai').expect;

function rgbToHexColor(red, green, blue) {
    if (!Number.isInteger(red) || (red < 0) || (red > 255))
        return undefined; // Red value is invalid
    if (!Number.isInteger(green) || (green < 0) || (green > 255))
        return undefined; // Green value is invalid
    if (!Number.isInteger(blue) || (blue < 0) || (blue > 255))
        return undefined; // Blue value is invalid
    return "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
}
describe('rgbToHexColor', function(){
    it("should return #FF9EAA on (255, 158, 170)", function() {
        let hex = rgbToHexColor(255, 158, 170);
        expect(hex).to.be.equal('#FF9EAA');
    }); 
    it('should return #000000 on (0, 0, 0)', function(){
        let hex = rgbToHexColor(0, 0,0);
        expect(hex).to.be.equal('#000000');
    })
    it('should return #0C0D0E on (12, 13, 14)', function(){
        let hex = rgbToHexColor(12, 13, 14);
        expect(hex).to.be.equal('#0C0D0E');
    })
    it('should return #FFFFFF on (255, 255, 255)', function(){
        let hex = rgbToHexColor(255, 255, 255);
        expect(hex).to.be.equal('#FFFFFF');
    })
})
