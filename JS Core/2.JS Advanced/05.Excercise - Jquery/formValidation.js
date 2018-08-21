function validate() {
    let username = $('#username');
    let email =$('#email');
    let password = $('#password');
    let confirmPassword = $('#confirm-password');
    let companyCheckbox = $('#company');
    let isValid = true;

    companyCheckbox.on('change', checkBox);
    $('#submit').on('click', validateForm);

    function validateForm(event){
        let isValidUsername = validateInputRegex(username, /^[A-Za-z\d]{3,20}$/);
        let isValidEmail = validateInputRegex(email, /^.*@.*\..*$/);
        
        if(password.val() === confirmPassword.val()){
            let isValidPassword = validateInputRegex(password, /^\w{5,15}$/);
            let isValidConfirmPass = validateInputRegex(confirmPassword,/^\w{5,15}$/);
        }else{
            password.css('border-color','red');
            confirmPassword.css('border-color','red');
            isValid = false;
        }
        validateInputRegex('#companyNumber', /^\d{4}$/);
        
        if(isValid){
            $('#valid').css('display','block');
        }else{
            $('#valid').css('display','none');
        }
        event.preventDefault();
    }
    function validateInputRegex(input, pattern){
        let element = $(input);
        let elementValue = element.val();
        if(!pattern.test(elementValue)){
            $(element).css('border-color','red');
            isValid = false;
        }else{
            $(element).css('border-color','');
        }
    }
    function checkBox(){
        if($(this).is(":checked")){
            $('#companyInfo').css('display', 'block');  
        }else{
            $('#companyInfo').css('display', 'none');
            isValid = false;
        }
    }
}
