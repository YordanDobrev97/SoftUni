function solve() {
    const types = new Map();
    for(let argument of arguments) {
        const typeArgument = typeof(argument);
        if (!types.has(typeArgument)) {
            types.set(typeArgument, {count: 0});
        }
        types.get(typeArgument).count++;
        console.log(`${typeArgument}: ${argument}`);
    }

    const sortedValues = [...types].sort((a,b) => {
        return b[1].count - a[1].count;
    });

    for(let item of sortedValues) {
        console.log(`${item[0]} = ${item[1].count}`);
    }
}
solve('cat', '42', function () { console.log('Hello world!'); });