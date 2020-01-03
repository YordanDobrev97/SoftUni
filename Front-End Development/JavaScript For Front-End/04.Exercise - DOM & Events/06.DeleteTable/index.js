function deleteByEmail() {
    let emailUser = document.getElementsByTagName('input')[0].value;
    
    if (isEmptyEmail(emailUser)) {
        invalidEmail();
    }

    const regexPattern = /(?<name>[a-zA-Z]+)@([a-z]+)\.[a-z]{3}/gm;
    const regex = new RegExp(regexPattern);
    
    if (!regex.test(emailUser)) {
        invalidEmail();
    }

    let allEmails = document.getElementsByTagName('tr');
    
     for (let i = 0; i < allEmails.length; i++) {
            const element = allEmails[i];
            let email =element.cells[1].textContent;
       
            if (email == emailUser) {
                element.remove();
                document.getElementsByTagName('input')[0].value= '';
                document.getElementById('result').textContent = 'Deleted Successfully';
                break;
            }
     }
    

    function invalidEmail() {
        document.getElementById('result').style.color = 'red';
        document.getElementById('result').textContent = 'Not found';
    }

    function isEmptyEmail(email) {
        return email.length === 0;
    }
}