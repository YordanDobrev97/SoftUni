function fromJSONToHTMLTable(input) {
  let parseJson = JSON.parse(input);
  let keys = Object.keys(parseJson[0]);

  let table = '<table>\n';

  table += '   <tr>';
  for (let key of keys) {
      table += `<th>${key}</th>`;
  }
  table += '</tr>\n'

  for (let index in parseJson) {
    let partOfTable = '   <tr>';
    table += partOfTable;
    let currentKeys = Object.keys(parseJson[index]).forEach((key) => {
        let val = parseJson[index][key];
        if (key === 'Name') {
            val = val
                    .replace(/&/gim, '&amp;')
                    .replace(/</gim, '&lt;')
                    .replace(/>/gim, '&gt;')
                    .replace(/"/gim, '&quot;')
                    .replace(/'/gim, '&#39;');
        }
        table += `<td>${val}</td>`;
    });
    table += '</tr>\n'
  }
  table += '</table>';
  return table;
}

console.log(
  fromJSONToHTMLTable(['[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]'])
);
