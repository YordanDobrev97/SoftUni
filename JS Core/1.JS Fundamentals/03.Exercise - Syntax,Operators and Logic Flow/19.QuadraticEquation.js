function quadraticEquation(a, b, c){
    let d = (b * b) - (4 * a * c);
    if(d < 0){
        console.log('No');
    }else if(d === 0){
        let x1 = Math.abs(-b / (2 * a));
        console.log(x1);
    }else{
       let x1 = (-b + Math.sqrt(d)) / (2 * a);
       let x2 = (-b - Math.sqrt(d)) / (2 * a);

       let min = Math.min(x1, x2);
       let max = Math.max(x1 ,x2);
       console.log(min);
       console.log(max);    
    }
}