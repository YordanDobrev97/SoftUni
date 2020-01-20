function solve(input) {
    let uniqueWords = [];
    const regex = /[\s+,\.\']/gm;

    for(let sequence of input) {
        let words = sequence.split(regex).filter(el => el !== '');
        for(let word of words) {
            if (!uniqueWords.includes(word.toLowerCase())) {
                uniqueWords.push(word.toLowerCase());
            }
        }
    }

    console.log(uniqueWords.join(', '));
}

solve(['Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 'Pellentesque quis hendrerit dui.', 
'Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla.', 
'Vestibulum dolor diam, dignissim quis varius non, fermentum non felis.', 
'Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut.', 
'Morbi in ipsum varius, pharetra diam vel, mattis arcu.', 
'Integer ac turpis commodo, varius nulla sed, elementum lectus.', 
'Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.']
);