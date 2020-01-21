function solve(input) {
  let result = '<table>\n';

  for (let i = 0; i < input.length; i++) {
    const parsed = JSON.parse(input[i]);
    result += '	<tr>\n';
    result += `		<td>${parsed.name}</td>\n`
    result += `		<td>${parsed.position}</td>\n`;
    result += `		<td>${parsed.salary}</td>\n`;
    result += '	</tr>\n'
  }
  result += '</table>'
  console.log(result);
}

solve([
  '{"name":"Pesho","position":"Promenliva","salary":100000}',
  '{"name":"Teo","position":"Lecturer","salary":1000}',
  '{"name":"Georgi","position":"Lecturer","salary":1000}'
]);
