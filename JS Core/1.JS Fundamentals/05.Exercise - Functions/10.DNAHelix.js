function helix(number){
    const sequence = 'ATCGTTAGGG';

    for(let i = 0; i< number; i++){
        let position = i % 4;
        let sequanceIndex = (i * 2) % sequence.length;
        switch(position){
            case 0:
                console.log(`**${sequence[sequanceIndex]}${sequence[sequanceIndex + 1]}**`);
                break;
            case 1:
            case 3:
            console.log(`*${sequence[sequanceIndex]}--${sequence[sequanceIndex + 1]}*`);
                 break;
            case 2:
            console.log(`${sequence[sequanceIndex]}----${sequence[sequanceIndex + 1]}`);
                 break;
        }
    }
}