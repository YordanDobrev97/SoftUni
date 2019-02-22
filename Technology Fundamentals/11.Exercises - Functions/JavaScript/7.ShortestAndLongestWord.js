function solve(input) {
    const regexExpression = /(\,|\s+|\?|\.)/gm;

    let elements = input.split(regexExpression);

    elements = elements.filter((el) => {
        return el !== ' ' && el !== '' && el !== ',' && el !== '?';
    });

    let maxLengthWord = getLongestWord();
    let minLengthWord = getShortest();

    console.log(`Longest -> ${maxLengthWord}`);
    console.log(`Shortest -> ${minLengthWord}`);



    function getShortest() {
        let lengthWord = Infinity;
        let wordWithMinLength = '';

        for(let word of elements) {
            let currentLengthWord = word.length;

            if (currentLengthWord < lengthWord) {
                lengthWord = currentLengthWord;
                wordWithMinLength = word;
            }
        }

        return wordWithMinLength;
    }
    function getLongestWord() {
        let lengthWord = 0;
        let wordWithMaxLength = '';
        for (let word of elements) {
            let currentLengthWord = word.length;
            if (currentLengthWord > lengthWord) {
                lengthWord = currentLengthWord;
                wordWithMaxLength = word;
            }
        }

        return wordWithMaxLength;
    }
}
solve('Hello people, are you familiar with the terms of application at the software university?')