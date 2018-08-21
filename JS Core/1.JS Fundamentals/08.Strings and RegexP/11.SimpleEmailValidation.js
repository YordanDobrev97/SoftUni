function validationEmail(email){
    let regex = /^[a-zA-Z0-9]+@[a-z]+(\.[a-z]+)+$/g;
    let result = regex.test(email);
    if(result)
    {
        console.log('Valid');
    }else{
        console.log('Invalid');
    }
}