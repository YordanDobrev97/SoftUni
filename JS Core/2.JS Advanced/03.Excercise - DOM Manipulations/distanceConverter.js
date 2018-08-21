function attachEventsListeners() {
    let inputDistance = document.getElementById('inputDistance');
    let from = document.getElementById('inputUnits').value;
    let to = document.getElementById('outputUnits').value;
    let button = document.getElementById('convert');
    let output = document.getElementById('outputDistance');
    
    let num = Number(inputDistance.value);
    let result = 0;
    if(from === 'km' && to === 'm'){
        result = num / 0.0010000;
    }else if(from === 'km' && to === 'cm'){
        result = num / 0.000010000;
    }else if(from === 'km' && to ==='mm'){
        result = num / 0.0000010000;
    }else if(from === 'km' && to === 'mi'){
        result = num * 0.62137;
    }else if(from === 'km' && to === 'yrd'){
        result = num * 1093.613298;
    }else if(from === 'km' && to === 'ft'){
        result = num * 3280.8;
    }else if(from === 'km' && to === 'in'){
        result = num * 39370.07874;
    }

    button.addEventListener('click', function(){
        output.value = result;
    })
}