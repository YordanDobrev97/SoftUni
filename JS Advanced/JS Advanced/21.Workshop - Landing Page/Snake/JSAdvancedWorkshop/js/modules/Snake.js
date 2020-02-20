import GameObject from './GameObject.js';
import SnakeBody from './SnakeBody.js';
import * as Helper from './helper.js';
import * as Engine from './gameEngine.js';

//This class represents the snake itself
export default class Snake extends GameObject {
    constructor() {
        // Here we can specify number of lives the snake has
        // lives
        
        // Snake has the ability to grow, so this field is not constant
        // length

        // the snake is green
        
        //Here we are logging positions which were visited by snake's head 
        // in order to know the way of the rest body parts
        // positionStack
        
        //This array holds snake's body parts - everything but the head
        // bodyArray
        
        //This field must be updated only using enumeration Directions. 
        // It keeps the direction in which the snake is moving.
        // direction;
        
        //This field holds number of eaten food in order to know when to grow. 
        // It is reset each time the snake grows.
        // foodEaten
        
        //This field is holding the total number of eaten food aka the score.
        //totalFood
    }

    //This method is called on update instead of GameObject default method
    update() {
        //Creates new position from the current snake's head position to store in the position stack

        //adds position to the stack

        //removes unneeded position from the stack's end
    
        //calculates new position depending on the current direction
    
        //updates all body parts' positions
    
        //checks if the snake has eaten enough food and if so makes it grow
        
    }

    //This method can be used with any user interface to change the snake's direction 
    //(may be it could be made public so the snake could be controlled from outside the engine)
    changeDirection() {

    }

    //This method describes how the snake manages collisions 
    onCollision() {
        // if the collision object is food it increases its foodEaten and totalFood fields
        // if the collision object is not food, 
        // it checks number of lives and if it is equal to 0 - dies, 
        //if not - decreases number of lives and resets it self
    }

    // This method makes the snake grow
    // It is creating new body element on the top of the last element 
    // (it is done to avoid difficult calculations)
    // on the next update they will have different positions and the snake will be longer
    grow() {
        // Create new position
        // Create new body part
        // Push body part to bodyArray and position to position stack
        // increase length
    }

    //This method is called when the snake dies, but have more lives. 
    //It wipes the snake and positions it in the left part of the field and sets direction to right
    reset() {
        // Set direction
        // Set snake head position (x is calculated, y is random)
        // Set all body parts positions according to head
        // Update position stack
    }

    //This method draws the snake, including all it's body parts and some statistics
    draw() {
        // Draw the head
        // Draw all body parts
        // Output number of lives and score
    }
    
    //This method returns true if the snake collides with itself
    hasBittenHerSelf() {
        
    }

    //This method returns true if the snake leaves the game field
    isOutOfGameField() {
        
    }
}