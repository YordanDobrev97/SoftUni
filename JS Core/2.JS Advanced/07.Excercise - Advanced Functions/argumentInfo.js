function argumentInfo(){
    let args = {};
    for(let i = 0; i<arguments.length;i++) {
        let obj = arguments[i];
        let type = typeof obj;
        console.log(`${type}: ${obj}`);

        if(!args.hasOwnProperty(type)){
            args[type] = 0;
        }
        args[type]++;
    }
    let sort = Object.keys(args).sort(function(a,b){return args[b] - args[a]});

    for(let item of sort)
    {
        console.log(`${item} = ${args[item]}`);
    }
}
argumentInfo('cat', 42, function () { console.log('Hello world!'); });