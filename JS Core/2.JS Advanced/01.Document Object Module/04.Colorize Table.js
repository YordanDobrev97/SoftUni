function colorize() {
  let items = document.querySelectorAll('table tr');
  let i = 1;
  for(let item of items)
  {
      if(i % 2 == 0)
      {
          item.style.backgroundColor = 'teal';
      }
      i++;
  }
}