function place(firstStr, symbol, secondStr){
    firstStr = firstStr.replace('_',symbol);
    
    if(firstStr == secondStr){
        console.log('Matched');
    }else{
        console.log('Not Matched');
    }
}
place('Str_ng', 'I', 'Strong');//strIng