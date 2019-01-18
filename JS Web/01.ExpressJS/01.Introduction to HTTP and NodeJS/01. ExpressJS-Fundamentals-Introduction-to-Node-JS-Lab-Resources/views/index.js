"use strict";

const http = require('http');
const port = 8080;
const handlers = require('');

http.
    createServer((req, res) => {
        for(let handler of handlers){
            if(!handler(req, res)){
                break;
            }
        }

    }).listen(port, console.log(`Server running on port ${port}`));