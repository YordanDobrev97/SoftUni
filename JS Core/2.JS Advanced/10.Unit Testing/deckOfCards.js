function printDeckOfCards(cards) {
    let result = [];
    for(let kvp of cards)
    {
        let card = kvp.substring(0, kvp.length - 1);
        let suit = kvp[kvp.length - 1];
        
        try {
            result.push(makeCard(card, suit));
        }
        catch(error) {
            console.log('Invalid card: ' + kvp);
            return;
        }
    }
    console.log(result.join(', '));
    function makeCard(card, suit){
        let cards = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K','A'];
        let suits = {
            S: '\u2660',
            H: '\u2665', 
            D: '\u2666',
            C: '\u2663'
        }
    if(!cards.includes(card) || suits[suit].hasOwnProperty(suit)){
        throw new Error(`Invalid card: ${card}${suits[suit]}`);
    }
    return `${card}${suits[suit]}`;
  }
}
printDeckOfCards(['AS', '10D', 'KH', '2C']);
printDeckOfCards(['5S', '3D', 'QD', '1C']);
  