function listProducts(products){
  let sort = products.sort();

  sort.forEach((item, pos) => console.log(`${pos + 1}.${item}`));
}
listProducts(['Banana', 'Tomato', 'Apples']);