function solve(input) {
  const system = {};

  for (let item of input) {
    const parts = item.split(" | ");
    const systemName = parts[0];
    const componentName = parts[1];
    const subComponentName = parts[2];

    if (!system.hasOwnProperty(systemName)) {
      system[systemName] = {};
    }

    if (!system[systemName].hasOwnProperty(componentName)) {
      system[systemName][componentName] = [];
    }
    system[systemName][componentName].push(subComponentName);
  }

  const sortedKeys = Object.keys(system).sort((a, b) => {
    if (Object.keys(system[b]).length === Object.keys(system[a]).length) {
      return a.localeCompare(b);
    }
    return Object.keys(system[b]).length - Object.keys(system[a]).length;
  });

  for (let item of sortedKeys) {
    console.log(item);
    const components = Object.keys(system[item]).sort((a, b) => {
      return (
        Object.keys(system[item][b]).length -
        Object.keys(system[item][a]).length
      );
    });
    for (let component of components) {
      console.log(`|||${component}`);
      const subComponentName = system[item][component];
      subComponentName.forEach(el => {
        console.log(`||||||${el}`);
      });
    }
  }
}
solve([
  "SULS | Main Site | Home Page",
  "SULS | Main Site | Login Page",
  "SULS | Main Site | Register Page",
  "SULS | Judge Site | Login Page",
  "SULS | Judge Site | Submittion Page",
  "Lambda | CoreA | A23",
  "SULS | Digital Site | Login Page",
  "Lambda | CoreB | B24",
  "Lambda | CoreA | A24",
  "Lambda | CoreA | A25",
  "Lambda | CoreC | C4",
  "Indice | Session | Default Storage",
  "Indice | Session | Default Security"
]);
