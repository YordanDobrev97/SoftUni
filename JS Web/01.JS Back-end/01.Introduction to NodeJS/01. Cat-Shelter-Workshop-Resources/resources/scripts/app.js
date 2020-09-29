const http = require('http');
const fs = require('fs');
const path = require('path');
const paths = require('./paths');
const crud = require('./crud');
const controllers = require('./controllers');

const defaultContentType = 'text/html';

http.createServer((req, res) => {
    crud.get('/', controllers.home(req, res));

    // let urlPath = paths(req.url);
    // if (!urlPath) {
    //     return;
    // }
    
    // const file = path.join(__dirname, 'public', urlPath);
    // const extName = path.extname(file);
    // let contentType = defaultContentType;

    // switch (extName) {
    //     case '.css': 
    //         contentType = 'text/css';
    //         break;
    // }

    // res.writeHead(200, {'Content-Type': contentType});
    // const readStream = fs.createReadStream(file);
    // readStream.pipe(res);

}).listen(3000, console.log('Server is working at port: 3000'));