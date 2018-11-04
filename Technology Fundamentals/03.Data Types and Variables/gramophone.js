function solve(nameOfBand, nameOfAlbum, nameSong){
    let rotation = (nameOfBand.length * nameOfAlbum.length) * nameSong.length / 2;

    rotation = Math.ceil(rotation / 2.5);
    console.log(`The plate was rotated ${rotation} times.`);
}
solve('Blank Sabbath', 'Paranoid', 'War Pigs');