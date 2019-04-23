function movies(input){
    let allMovies = [];

    for(let item of input) {
        let partsMovie = item.split(' ');
        
        let objMovie = {};
        if (partsMovie[0] === 'add'){
            let nameMovie = partsMovie.slice(2).join(' ');
            objMovie.name = nameMovie;
            allMovies.push(objMovie);
        } else {
           let nameMovie = getNameMovie(partsMovie);
           
           if (hasCurrentMovie(nameMovie)) {
                addPropertyCurrentMovie(nameMovie, parts);
           }
        }
    }

    function addPropertyCurrentMovie(nameMovie, parts) {
        for(let item of allMovies) {
            let hasCurrentMovie = containsMovie(item, nameMovie);

            if(hasCurrentMovie) {
                let obj = item;
                let property = getProperty(parts);
                let value = getValue(parts);
                obj[property] = value;
            }
        }
    }

    function getValue(parts) {
        let lastIndex = parts.length - 1;

        let value = [];
        while(parts[lastIndex] !== 'by' && parts[lastIndex] !== 'data') {
            let currentValue = parts[lastIndex];
            value.push(currentValue);
            lastIndex--;
        }

        let result = value.join(' ');
        return result;
    }

    function getProperty(parts) {
        if (parts.inchludes('directed')) {
            return 'directed by';
        } else {
            return 'on data';
        }
    }

    function hasCurrentMovie(movie) {
        let contains = false;
        for(let obj of allMovies) {
            if (containsMovie(obj, movie)) {
                contains = true;
                break;
            }
        }
        return contains;
    }

    function containsMovie(foundMovie, movieFromArray) {
        let obj = foundMovie['name'];
        return obj === movieFromArray;
    }

    function getNameMovie(parts) {
        let fillNameMovie = [];
        let index = 0;
        while (parts[index] !== 'directed' && parts[index] !== 'on') {
            let partOfName = parts[index];
            fillNameMovie.push(partOfName);
            index++;
        }
        let nameMovie = fillNameMovie.join(' ');
        return nameMovie;
    }


}
movies(['add movie Fast and Furious',
'add movie Godfather',
'Inception directed by Christopher Nolan',
'Godfather directed by Francis Ford Coppola',
'Godfather on date 29.07.2018',
'Fast and Furious on date 30.07.2018',
'Batman on date 01.08.2018',
'Fast and Furious directed by Rob Cohen']
);