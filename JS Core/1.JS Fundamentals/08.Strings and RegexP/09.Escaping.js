function escaping(array){
    let result = '<ul>\n'
    for(let item of array)
    {
        let line = item.replace(/&/g, '&amp;')
        .replace(/>/g, '&gt;')
        .replace(/"/g, '&quot;')
        .replace(/</g, '&lt;');

        result +=`  <li>${line}</li>\n`;
    }
    result +='</ul>'

    console.log(result);
}