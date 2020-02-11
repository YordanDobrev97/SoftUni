function solve(card, suit) {
    const validFacesCard = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const validSuits = ['S', 'H', 'D', 'C'];

    if (!validFacesCard.includes(card) || !validSuits.includes(suit)) {
        throw new Error();
    }
    const suitFace = {
        'S': '(♠)',
        'H': '(♥)',
        'D': '(♦)',
        'C': '(♣)'
    };
    const currentSuit = suitFace[suit];
    return `${card}${currentSuit}`;
}
console.log(solve('1', 'C'));