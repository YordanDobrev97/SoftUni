
const apiKey = 'https://team-manager-64798.firebaseio.com/';

async function loadCommon() {
    this.partials = {
        header: await this.load('../templates/common/header.hbs'),
        footer: await this.load('../templates/common/footer.hbs')
    };

    this.loggedIn = !!sessionStorage.getItem('token');
    this.username = sessionStorage.getItem('username');
    this.hasNoTeam = true;
}

async function getHomePage() {
    await loadCommon.call(this);
    this.partial('../templates/home/home.hbs');
}


async function getAboutPage() {
    await loadCommon.call(this);
    this.partial('../templates/about/about.hbs');
}

async function getLoginPage(context) {
    await loadCommon.call(this);
    this.partials.loginForm = await this.load('../templates/login/loginForm.hbs');

    await this.partial('../templates/login/loginPage.hbs');

    const form = document.getElementsByTagName('form')[0];

    form.addEventListener('submit', function(e){
        e.preventDefault();

        const username = document.getElementById('username');
        const password = document.getElementById('password');

        firebase.auth().signInWithEmailAndPassword(username.value, password.value)
            .then(response => {
                firebase.auth().currentUser.getIdToken().then(token => {
                    sessionStorage.setItem('token', token);
                    sessionStorage.setItem('username', response.user.email);
                });
                context.redirect('/#home');
            });
    });
   
}

async function getRegisterPage(context) {
    await loadCommon.call(this);
    this.partials.registerForm = await this.load('../templates/register/registerForm.hbs');

    await this.partial('../templates/register/registerPage.hbs');

    const form = document.getElementsByTagName('form')[0];

    form.addEventListener('submit', function(e){
        e.preventDefault();
       
        const username = document.getElementById('username');
        const password = document.getElementById('password');
        const repeatPassword = document.getElementById('repeatPassword');

        if (password.value !== repeatPassword.value) {
            return;
        }

        firebase.auth().createUserWithEmailAndPassword(username.value, password.value)
            .then(response => {
                firebase.auth().currentUser.getIdToken().then(token => {
                    sessionStorage.setItem('token', token);
                    sessionStorage.setItem('username', response.user.email);
                });
            }).then(() => {
                username.value = '';
                password.value = '';
                repeatPassword.value = '';
                context.redirect('/#home');
            })
    });
}

async function logout(context) {
    sessionStorage.clear();
    firebase.auth().signOut();
    context.redirect('/#home');
}

async function create(context) {
    await loadCommon.call(this);
    this.partials.createForm = await this.load('../templates/create/createForm.hbs');

    await this.partial('../templates/create/createPage.hbs');
}

const app = $.sammy('#main', function(){
    this.use('Handlebars', 'hbs');

   this.get('/#home', getHomePage);
   this.get('/#about', getAboutPage);
   this.get('/#login', getLoginPage);
   this.get('/#register', getRegisterPage);
   this.get('/#logout', logout);
 
   this.post('/#login', () => false);
   this.post('#register', () => false);
});  

(() => {
    app.run('/#home');
})();