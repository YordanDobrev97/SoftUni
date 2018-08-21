function templateFromat(array){
    let result = '<?xml version="1.0" encoding="UTF-8"?>\n<quiz>\n';
    for(let i = 0; i < array.length; i+=2){
        result +='  <question>\n';
        result +=`    ${array[i]}\n`;
        result +='  </question>\n';
        
        result +='  <answer>\n';
        result +=`    ${array[i + 1]}\n`;
        result +='  </answer>\n';
    }
    result +='</quiz>';
    console.log(result);
}