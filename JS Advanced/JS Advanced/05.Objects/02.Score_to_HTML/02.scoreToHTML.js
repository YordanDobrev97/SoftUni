function solve(input) {
  let table = "<table>\n";
  table += "  <tr><th>name</th><th>score</th></tr>\n";

  let parseJson = JSON.parse(input);
  for (let index in parseJson) {
    let name = parseJson[index].name
                .replace(/&/gim, '&amp;')
                .replace(/</gim, '&lt;')
                .replace(/>/gim, '&gt;')
                .replace(/"/gim, '&quot;')
                .replace(/'/gim, '&#39;');

    let score = Number(parseJson[index].score);

    table += `  <tr><td>${name}</td><td>${score}</td></tr>\n`;
  }
  table += "</table>";

  return table;
}

console.log(
  solve(['[{"name":"Pesho <scirpt>console.log(\'hi\')</script> Kiro","score":479}, {"name":"Gosho","score":205}]']));
