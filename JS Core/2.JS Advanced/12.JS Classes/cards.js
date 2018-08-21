(function() {
    let Suits = {    CLUBS: "\u2663"};    // ♣    DIAMONDS: "\u2666", // ♦    HEARTS: "\u2665",   // ♥    SPADES: "\u2660"    // ♠  };
    let Faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    class Card {
        constructor(suit, face){
            this.suit = suit;
            this.face = face;
        }
        get face() {return this._face};
        set face(newFace) {
            if(!Faces.includes(newFace)){
                throw new Error("Invalid card face: " + face);
            }
            this._face = newFace;
        }
        get suit() {return this._suit};
        set suit(){
            
        }
    }
    return { Suits, Card }
  }())
  