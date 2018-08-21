function attachGradientEvents(){
    let gradientId = document.getElementById('gradient');
    gradientId.addEventListener('mousemove', gradientMove);
    gradientId.addEventListener('mouseout', gradientOut);
    
    function gradientMove(event){
        let power = event.offsetX / (event.target.clientWidth - 1);
        power = Math.trunc(power * 100);
        document.getElementById('result').textContent = power + '%';
    }
    function gradientOut(){
        document.getElementById('result').textContent = '';
    }

}