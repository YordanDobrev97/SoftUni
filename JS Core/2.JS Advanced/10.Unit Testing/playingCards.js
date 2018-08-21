function cards(card, suit){
    let cards = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K','A'];
    let suits = {
        S: '\u2660',
        H: '\u2665', 
        D: '\u2666',
        C: '\u2663'
    }
    if(!cards.includes(card) || suits[suit].hasOwnProperty(suit)){
        throw new Error('Error');
    }

    toString: {
        return `${card}${suits[suit]}`;
    }
}
console.log(cards('10', 'H'));