function solve(input) {
    const object = {};
   
    for(let item of input) {
        const parts = item.split(' | ');
        const systemName = parts[0];
        const componentName = parts[1];
        const subcomponentName = parts[2];

        if (!object.hasOwnProperty(systemName)) {
            object[systemName] = {};
        }

        if (!object[systemName].hasOwnProperty(componentName)) {
            object[systemName][componentName] = [];
        }
        object[systemName][componentName].push(subcomponentName);
    }

    
}
solve(['SULS | Main Site | Home Page',
'SULS | Main Site | Login Page',
'SULS | Main Site | Register Page',
'SULS | Judge Site | Login Page',
'SULS | Judge Site | Submittion Page',
'Lambda | CoreA | A23',
'SULS | Digital Site | Login Page',
'Lambda | CoreB | B24',
'Lambda | CoreA | A24',
'Lambda | CoreA | A25',
'Lambda | CoreC | C4',
'Indice | Session | Default Storage',
'Indice | Session | Default Security']
);