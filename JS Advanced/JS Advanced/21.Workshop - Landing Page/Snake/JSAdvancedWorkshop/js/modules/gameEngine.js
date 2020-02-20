import GameField from './GameField.js';
import Snake from './Snake.js';
import SnakeBody from './SnakeBody.js';
import Food from './Food.js';
import Stone from './Stone.js';
import * as Helper from './helper.js';

// This array contains all objects on the field
var gameObjects = [],
gameField = new GameField(document.getElementById('gameField')),
intervalId = 0,
snake = null;

// This is the only public method and it is used to initialize game objects 
// and to start the game.
function startGame() {
var snakeLength = parseInt(document.getElementById("snakeLength").value),
    numberOfStones = parseInt(document.getElementById("stonesNumber").value),
    numberOfFood = parseInt(document.getElementById("foodNumber").value),
    stone = null,
    food = null,
    snakeBody = null,
    i = 0;

    // This code prevents duplicating of objects on multiple calls of StartGame. 
    // Every call generates new game objects and starts the game from the beginning
    gameObjects = [];
    clearInterval(intervalId);

    // validates user input
    if (snakeLength > ((gameField.size.WIDTH - 100) / Helper.ObjectSize.WIDTH) || snakeLength <= 1) {
        snakeLength = 3;
    }

    if (numberOfStones < 0) {
        numberOfStones = 10;
    }

    if (numberOfFood <= 0) {
        numberOfFood = 5;
    }

    // create new snake
    
    // create body parts and push them to bodyArray
    // push positions into position stack
    // add snake to gameObjects
    
    //create stones and push them into gameObjects

    //create food and push it into gameObjects
    
    // attach event to the body element, listen to "keydown" event and call the getKey event handler
    document.addEventListener("keydown", getKey, false);

    //draws the game field
    gameField.draw(gameObjects);

    //calls update method each 100 milliseconds (this parameter controls the game speed)
    //with this code it is possible to implement increasing game speed
    intervalId = setInterval(update, Helper.GameSpeed);
}

//This method stops the updating of game field and waits for final updates.
//Then loads afterEndGameEvents method
function endGame() {
    clearInterval(intervalId);
    setTimeout(afterEndGameEvents, Helper.GameSpeed);
}

//This method is called after the end of the game.
//It clears the game field and shows a "Game Over" sign. 
function afterEndGameEvents() {
    var fontSize = 60;

    gameField.ctx.clearRect(0, 0, gameField.size.WIDTH, gameField.size.HEIGHT);
    gameField.ctx.font = fontSize + "px Arial";
    gameField.ctx.textAlign = 'center';
    gameField.ctx.fillStyle = "green";
    gameField.ctx.fillText("Game Over", gameField.size.WIDTH / 2, gameField.size.HEIGHT / 2);
}

// This method is called each gameSpeed milliseconds to update the states of all game objects
function update() {
    // call update methods of all game objects
    // call collisionDetect to handle collisions, than calls update methods of all game objects to update their states
    // redraws game field
}

// This method handles collisions
function collisionDetect() {
    var i = 0;

    //checks if snake has left the game field and if so, calls snakes onCollision method to handle it

    //checks if snake has bitten itself and if so, calls it's onCollision method to handle it

    //checks for collisions with other objects and if so calls their onCollision methods to handle them
}

//This method is making actual calculation to find out if there is a collision.
function collide(snakeObj, obj) {
    var result = false;

    // If top left corner and bottom right corner of two objects are equal, there is a collision
    if (snakeObj.position.X === obj.position.X && snakeObj.position.Y === obj.position.Y &&
        snakeObj.position.X + ObjectSize.WIDTH === obj.position.X + ObjectSize.WIDTH &&
        snakeObj.position.Y + ObjectSize.HEIGHT === obj.position.Y + ObjectSize.HEIGHT) {
        result = true;
    }

    return result;
}

//This method handles onKeyDown event
function getKey(evt) {
    switch (evt.keyCode) {
        //Left arrow key, calls changeDirection method of the snake
        case 37:
            break;
        //Up arrow key, calls changeDirection method of the snake
        case 38:
            break;
        //Right arrow key, calls changeDirection method of the snake
        case 39:
            break;
        //Down arrow key, calls changeDirection method of the snake
        case 40:
            break;
        //Letter "q" pressed, brings up confirm dialog, ends the game if OK pressed
        case 81:
            break;
        //Letter "p" pressed, brings up alert dialog, showing that game is on pause. 
        //Resumes the game if OK pressed
        case 80:
            alert("Paused. Press OK to continue.");
            break;
        default:
    }
}

export { startGame, endGame };