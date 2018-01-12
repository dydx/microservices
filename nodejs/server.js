'use strict';

const express = require('express');

const port = process.env.PORT || 3000;

const app = express();

app.get('/', (req, res) => {
  res.send('Node.JS microservice');
});

app.listen(port, () => {
  console.log(`Running on http://localhost:${port}`);
});
