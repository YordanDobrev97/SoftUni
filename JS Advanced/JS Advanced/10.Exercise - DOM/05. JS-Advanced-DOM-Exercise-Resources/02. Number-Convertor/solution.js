function solve() {
  const btn = document.getElementsByTagName("button")[0];
  const selectedMenu = document.getElementById("selectMenuTo");
  const result = document.getElementById('result');

  const binary = document.createElement("option");
  binary.value = "binary";
  binary.innerHTML = "Binary";
  selectedMenu.add(binary);

  const hexadecimal = document.createElement("option");
  hexadecimal.value = "hexadecimal";
  hexadecimal.innerHTML = "Hexadecimal";
  selectedMenu.add(hexadecimal);

  btn.addEventListener("click", () => {
    const number = document.getElementById("input");
    if (selectedMenu.value === 'binary'){
        const binary = Number(number.value).toString(2);
        result.value = binary;
    } else if (selectedMenu.value === 'hexadecimal') {
        const hexaDecimal = Number(number.value).toString(16).toUpperCase();
        console.log(hexaDecimal);
        result.value = hexaDecimal;
    }
  });

  document.getElementById("input").value = '';
}
