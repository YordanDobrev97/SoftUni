function censorship(text, arrayOfWantedWords){
    for(let item of arrayOfWantedWords)
    {
        let replace = '-'.repeat(item.length);
        while(text.indexOf(item) > 1){
            text = text.replace(item, replace);
        }
    }
    console.log(text);
}