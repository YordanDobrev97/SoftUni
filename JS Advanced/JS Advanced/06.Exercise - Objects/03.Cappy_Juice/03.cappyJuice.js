function solve(input) {
  const map = new Map();
  const quantityProducts = new Map();

  for (let item of input) {
    const parts = item.split(" => ");
    const juiceName = parts[0];
    const quantity = Number(parts[1]);

    if (!quantityProducts.has(juiceName)) {
      quantityProducts.set(juiceName, {quantity});
    } else {
      quantityProducts.get(juiceName).quantity += quantity;
    }

    if (isCanMakeJuice(juiceName)) {
       const bottles = Math.floor(quantityProducts.get(juiceName).quantity / 1000);
       const remainder =  Math.floor(quantityProducts.get(juiceName).quantity % 1000);
       quantityProducts.get(juiceName).quantity = remainder;
       
       if (!map.has(juiceName)) {
         map.set(juiceName, {bottles});
       } else {
         map.get(juiceName).bottles += bottles;
       }
    }
  }

  function isCanMakeJuice(juiceName) {
    return quantityProducts.get(juiceName).quantity >= 1000;
  }

  const elements = map.entries();
  for(let item of elements) {
    let key = item[0];
    let bottles = item[1].bottles;
    console.log(`${key} => ${bottles}`);
  }
}

solve(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789']

);
