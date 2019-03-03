//using like class
function Square(x, y, color, id) {
    this.pos = createVector(x, y);
    this.width = 80;
    this.mainValue = '';
    this.secondaryValue = '';
    this.color = color;
    this.id = id;
}

Square.prototype.show = function () {
    
    fill(this.col.x, this.col.y, this.col.z);
    stroke(255);
    strokeWeight(3);
    rect(this.pos.x, this.pos.y, this.pos.width, this.pos.width, 10);

    let fillValue = 255;
    if (this.mainValue && this.secondaryValue) {
        fill(fillValue);
        textSize(30);
        text(this.mainValue, this.pos.x + 20, this.pos.y + 50);
        fill(fillValue);
        textSize(18);
        text(this.secondaryValue, this.pos.x + 50, this.pos.y + 55);
    } else {
        fill(fillValue);
        textSize(30);
        text(this.mainValue, this.pos.x + 30, this.pos.y + 50);
    }
}