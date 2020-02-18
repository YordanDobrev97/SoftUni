const http = require('http');
const fs = require('fs');
const port = 8000;

http.createServer((req, res) => {
    const stream = fs.createReadStream('./data.txt');
    stream.setEncoding('utf8');
    stream.on('error', function(data) {
        res.write(`<p>Not Found!</p>`);
    });

    stream.on('data', function(data) {
        const items = data.split('\n')
            .forEach(el => {
                res.write(`<h1>${el}</h1>`)
        })
    });

    stream.on('end', function() {
        res.end();
    });
})
.listen(port, console.log(`server listening on port ${port}`));