const fs = require('fs');

function readUsers() {
    return fs.readFile('./data.txt', {encoding: 'utf-8'}, (err, data) => {
        if (err) {
            throw new Error();
        }
        
        console.log(data);
    });
}

module.exports = {
    readUsers
}