function solve(cards) {
    class Card {
        constructor(card) {
           this.face = splitCard(card)[0];
           this.suit = splitCard(card)[1];
        }

        get card() {
            const suitFace = {
                'S': '\u2660 ',
                'H': '\u2665 ',
                'D': '\u2666 ',
                'C': '\u2663 '
            };
            const currentSuit = suitFace[this.suit];
            return `${this.face}${currentSuit}`;
        }
    }

    function splitCard(card) {
        let face = '';
        let suit = '';
        if (card.length === 2) {
           face = card.slice(0, 1);
           suit = card.slice(1);
        } else {
            face = card.slice(0, 2);
            suit = card.slice(2);
        }
        return [face, suit];
    }

    function isValid(card) {
        const [face, suit] = splitCard(card);
        const validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        const validSuits = ['S', 'H', 'D', 'C'];

        return validFaces.includes(face) && validSuits.includes(suit);
    }

    const validCards = [];
    let isValidCard = true;
    for(let card of cards) {
        if (!isValid(card)) {
            isValidCard = false;
            console.log(`Invalid card: ${card}`);
            return;
        }

        const newCard = new Card(card);
        validCards.push(newCard.card);
    }

    if (isValidCard) {
        console.log(validCards.join(' '));
    }
}
solve(['AS', '10D', 'KH', '1C']); //A♠ 10♦ K♥ 2♣