function toggle() {
  const btn = document.getElementsByClassName("button")[0];
  
  if (btn.textContent === 'More') {
    document.getElementById("extra").style.display = "block";
    btn.textContent = 'Less';
  } else {
    document.getElementById("extra").style.display = 'none';
    btn.textContent = 'More';
  }
}
