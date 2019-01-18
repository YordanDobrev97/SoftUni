const url = require('url');
const fs = require('fs');
const path = require('path');

function viewInformation(req, res, path){
    let path = path.normalize(path.join(__dirname, '../views/home/index.html'));
        fs.readFile(path, (error, data) => {
            if(error){
                console.log(error);
                res.writeHead(400, {
                    'Content-Type':'text/plain'
                })
                res.writeHead('Not Found!');
                res.end();
            }else{
                res.writeHead(200, {
                    'Content-Type': 'text/plain'
                });
                res.write(data);
                res.end();
            }
        });
}
module.exports = (req, res) => {
    req.pathname = req.pathname || url.parse(req.url).pathname;
    viewInformation(req,res, path);
    // if(req.pathname === '/' && req.method === 'GET'){
      
    // }else{
        
    // }
};