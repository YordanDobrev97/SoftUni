function toggle() {
    let element = document.getElementById('extra');

    let button = document.getElementsByClassName('button')[0];
    
    if (button.textContent === 'More'){
        element.style.display = 'inline';
        button.textContent = 'Less';
    } else  {
        button.textContent = 'More';
        element.style.display = 'none';
    }
}