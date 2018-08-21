function parseEmployee(employees){
    let result = [];
    let regex = /^([A-Z][A-Za-z]*) - ([1-9][0-9]*) - ([A-Za-z0-9- ]+)$/;
    for(let item of employees)
    {
        let match = regex.exec(item);
        if(match !== null)
        {
            result.push(`Name: ${match[1]}`);
            result.push(`Position: ${match[3]}`);
            result.push(`Salary: ${match[2]}`);
        }
    }
    console.log(result.join("\n"));
}