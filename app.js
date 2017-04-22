var express = require('express');
var app = express();

app.get('/', function (req, res) {
    res.send('Hello World!');
})

var port = process.env.PORT || 1337;
server.listen(port);

console.log("Server running at http://localhost:%d", port);