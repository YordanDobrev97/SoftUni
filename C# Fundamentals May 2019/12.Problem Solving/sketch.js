let field = [];// n x n field (matrix)

function setup() {
    createCanvas(600,600);//createCanvas – build-in function in the p5 library. It allows us to draw a canvas with specific width and height
    background(255,201, 147); //build-in function that receives 3 values (r, g, b) to set up the color of the canvas
    createGame();
}

function createGame() {
    let id = 1;
    let xOff = 100;
    let yOff = 100;

    for (let i = 0; i < 4; i++) {
        for (let j = 0; j < 4; j++) {
            let col = null;

            if (i >=1 && i <= 2 && j >= 1 && j <= 2) {
                col = createVector(214,113, 96);
            } else {
                col = createVector(115, 138, 239);
            }

            let squre = new Square(xOff, yOff, col, id);
            id++;
            field.push(squre);
            xOff +=100;
        }

        yOff += 100;
        xOff = 100;
    }
}

function draw() {
   for (const squre of field) {
       squre.show();
   }
}