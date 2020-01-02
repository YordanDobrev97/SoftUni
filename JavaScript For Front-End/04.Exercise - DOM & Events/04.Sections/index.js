function create(elements){
    for(let item of elements) {
        let div = document.createElement('div');
        let p = document.createElement('p');
        p.style.display='none';
        p.textContent= item;
        div.appendChild(p);
        div.addEventListener('click',show);
        document.getElementById('content').appendChild(div);
    
        function show() {
            this.firstChild.style.display = 'inline';
        }
    }
}