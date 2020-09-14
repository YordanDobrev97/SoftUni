const http = require('http');
const fs = require('fs');
const path = require('path');
const router = require('./router');

const defaultContentType = 'text/html';

http.createServer((req, res) => {
    let urlPath = router(req.url);
    if (!urlPath) {
        return;
    }
    
    const file = path.join(__dirname, 'public', urlPath);
    const extName = path.extname(file);
    let contentType = defaultContentType;

    switch (extName) {
        case '.css': 
            contentType = 'text/css';
            break;
    }

    res.writeHead(200, {'Content-Type': contentType});
    const readStream = fs.createReadStream(file);
    readStream.pipe(res);

}).listen(3000, console.log('Server is working at port: 3000'));