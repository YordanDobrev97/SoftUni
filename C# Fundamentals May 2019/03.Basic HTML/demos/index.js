let p = document.getElementById('content');
for (let i = 1; i <=6; i++){
    //<h1></h1>
    p.innerHTML = `<h${i}>H</h${i}>`;
    console.log(p.innerHTML);
}