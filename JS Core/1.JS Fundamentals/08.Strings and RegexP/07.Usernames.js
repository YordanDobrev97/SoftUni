function usernames(array){
    let result = [];
    for(let item of array)
    {
        let items = item.split('@');
        let name = items[0] + ".";
        let domain = items[1].split('.');
        for(let d of domain){
            let element = d[0];
            name = name + element;
        }
        result.push(name);
    }
    console.log(result.join(", "));
}