
const url = require('url');
const fs = require('fs');
const path = require('path');

function processingRequests(req, res){
    let parseUrl = url.parse(req.url).pathname;

    if(req.url === '/'){
        let readFile = fs.createReadStream('./index.html');
//console.log(__dirname);
        //readFile.pipe(res);
        // fs.readFile('C:\\Users\\DELL\\Documents\\GitHub\\SoftUni\\JS Web\\01.ExpressJS\\01.Introduction to HTTP and NodeJS\\01. ExpressJS-Fundamentals-Introduction-to-Node-JS-Lab-Resources\\views\\home\\index.html', (err, data) => {
        //     if(err){
        //         throw err;
        //     }else{
        //         res.writeHead(200, {
        //             'Content-Type': 'text/html'
        //         });
        //         res.write(data);
        //         res.end();
        //     }
        // })
       //let readFile = fs.createReadStream('../handlers/views/home/index.html');
    }
}

function viewInformation(req, res, path){

    const parseUrl = url.parse(req.url);

    if(parseUrl === '/'){
        const indexFile = fs.createReadStream('../views/home/index.html');

        indexFile.pipe(res);
    }
    // let path = path.normalize(path.join(__dirname, '../views/home/index.html'));
    //     fs.readFile(path, (error, data) => {
    //         if(error){
    //             console.log(error);
    //             res.writeHead(400, {
    //                 'Content-Type':'text/plain'
    //             })
    //             res.writeHead('Not Found!');
    //             res.end();
    //         }else{
    //             res.writeHead(200, {
    //                 'Content-Type': 'text/plain'
    //             });
    //             res.write(data);
    //             res.end();
    //         }
    //     });
}
module.exports = processingRequests;