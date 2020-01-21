function solve(input) {
  const map = new Map();
  const remaindMap = new Map();

  for (let item of input) {
    let [juiceName, quantity] = item.split(" => ");
    quantity = Number(quantity);

    if (quantity >= 1000) {
      if (!map.has(juiceName)) {
        map.set(juiceName, { quantity });
      } else {
        map.get(juiceName).quantity += quantity;
      }
    } else {
      if (!remaindMap.has(juiceName)) {
        remaindMap.set(juiceName, { quantity });
      } else {
        remaindMap.get(juiceName).quantity += quantity;
      }
    }
  }

  for (let [key, value] of map.entries()) {
    let bottles = Math.floor(value.quantity / 1000);

    for (let [juice, quantity] of remaindMap.entries()) {
        if (juice === key) {
           let rem = value.quantity % 1000;
           let total = rem + quantity.quantity;
           let additionally = Math.floor((rem + total) / 1000);
           if (total >= 1000) {
              bottles += additionally;
           }
        }
    }

    if (bottles > 0) {
      console.log(`${key} => ${bottles}`);
    }
  }
}

solve(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789']
);
