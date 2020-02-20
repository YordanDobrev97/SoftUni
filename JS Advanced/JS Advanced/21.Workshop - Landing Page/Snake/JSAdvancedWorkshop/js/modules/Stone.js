import GameObject from './GameObject.js';

//Stones definition
//This class represents stones which the snake must avoid
export default class Stone extends GameObject {
    constructor() {
        // grey
    }

    //Stones don't need update, but each object must have update method
    update() {
    
    }
}

