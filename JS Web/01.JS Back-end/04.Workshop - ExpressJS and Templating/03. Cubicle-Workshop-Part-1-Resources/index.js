const env = process.env.NODE_ENV || 'development';

const config = require('./config/config')[env];
const app = require('express')();

const express = require('./config/express');
express(app);

require('./config/routes')(app);

app.listen(config.port, console.log(`Listening on port ${config.port}! Now its up to you...`));