function solve(songs) {
    let numberSong = Number(songs.shift());
    class Song {
        constructor(typeList, name, time) {
            this.typeList  = typeList;
            this.name = name;
            this.time = time;
        }
    }

    let typeListPublic = songs.pop();

    let allSong = [];
    for (let i = 0; i < numberSong; i++) {
        let elements = songs[i];
        let items = elements.split('_');
        let typeList = items[0];
        let name = items[1];
        let time = items[2];
        
        let currentSong = new Song(typeList, name, time);
        allSong.push(currentSong);
    }
    let filterSong;
    if (typeListPublic === 'all') {
        filterSong = allSong;
    } else {
        filterSong = allSong.filter(el => el.typeList === typeListPublic);
    }
    
    for(let song of filterSong) {
        console.log(song.name);
    }
}
solve(['3', 
'favourite_DownTown_3:14',
'favourite_Kiss_4:16',
'favourite_Smooth Criminal_4:01',
'favourite']);
// solve(['4',
// 'favourite_DownTown_3:14',
// 'listenLater_Andalouse_3:24',
// 'favourite_In To The Night_3:58',
// 'favourite_Live It Up_3:48',
// 'listenLater']);