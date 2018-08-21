function CheckFruitOrVegetable(string){
    //tomato, cucumber, pepper, onion, garlic, parsley
    if(string === 'banana' || string === 'apple' 
    || string === 'kiwi' || string === 'cherry' 
    || string === 'lemon' || string === 'grapes'
    || string === 'peach'){
        console.log('fruit');
    }else if(string === 'tomato' || string === 'cucumber'
    || string === 'pepper' || string === 'onion' 
    || string === 'garlic' || string === 'parsley'){
        console.log('vegetable');
    }else{
        console.log('unknown');
    }
}