"use strict";
const http = require('http');
const port = 8080;
//console.log(__dirname);

const handlers = require('../handlers/index');
const url = require('url');
const fs = require('fs');

http.
    createServer((req, res) => {
       handlers(req,res);

}).listen(port, console.log(`Server running on port ${port}`));