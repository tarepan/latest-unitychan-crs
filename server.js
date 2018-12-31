// moduleをrequire
const express = require("express");
const app = express();

// getパラメータに対する処理を記述
// app.get("/", (request, response) => {
//     // response.writeHead(200);
//     // response.write('hello world');
//     // res.end();
//     // -> expressでの場合、こう書くこともできる
//     response.status(200).send("Hello World");
// });

app.use(express.static("Builds"));
// ポート指定で接続
app.listen(3000);