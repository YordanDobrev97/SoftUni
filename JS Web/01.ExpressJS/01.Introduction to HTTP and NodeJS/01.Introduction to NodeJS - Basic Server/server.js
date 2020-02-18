const http = require("http");
const url = require("url");
const fs = require("fs");
const port = 8000;

http.createServer((req, res) => {
    const path = url.parse(req["url"]).pathname;
    if (path === "/users") {
      fs.readFile("./data.txt",  {encoding: 'utf-8'}, (err, data) => {
        if (err) {
          throw new Error();
        }

        let users = data.split(", ");
        users.forEach(user => {
          res.write(`Hello ${user}\n`);
        });
        res.end();
      });
    } else {
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/plain');
        res.write('Hello, World!');

        res.end();
    }
  })
  .listen(port, console.log(`server listening on port ${port}`));
