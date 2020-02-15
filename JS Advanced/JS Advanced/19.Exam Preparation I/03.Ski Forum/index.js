class Forum {
    constructor() {
        this.users = [];
        this.questions = [];
        this.id = 1;
    }

    register(username, password, repeatPassword, email) {
        if (username === '' || password === ''  || repeatPassword === '' || email === '') {
            throw new Error('Input can not be empty');
        }

        if (password !== repeatPassword) {
            throw new Error('Passwords do not match');
        }

        if (this.users.some(x => x.username === username)) {
            throw new Error('This user already exists!');
        }
        const user = {
            username,
            email,
            password,
            isLogin: false
        }

        this.users.push(user);
        return `${username} with ${email} was registered successfully!`;
    }

    login(username, password) {
       if (!this.containsUser(username)) {
           throw new Error('There is no such user');
       }

        if (this.match(username, password)) {
            const userIndex = this.getUsernameIndex(username);
            this.users[userIndex].isLogin = true;
            return 'Hello! You have logged in successfully';
        }
    }

    logout(username, password) {
        if (!this.contains(username)) {
            throw new Error('There is no such user');
        }

        if (this.match(username, password)) {
            const userIndex = this.getUsernameIndex(username);
            this.users[userIndex].isLogin = false;
            return 'You have logged out successfully';
        }
    }

    postQuestion(username, question) {
        const userIndex = this.getUsernameIndex(username);
        if (!this.containsUser(username) || !this.users[userIndex].isLogin) {
            throw new Error('You should be logged in to post questions');
        }

        if (question === '') {
            throw new Error('Invalid question');
        }

        const questionMap = new Map();
        questionMap.set(this.id, question);

        this.questions.push(questionMap);
        this.id++;
        return 'Your question has been posted successfully';
    }

    postAnswer(username, questionId, answer) {
        const userIndex = this.getUsernameIndex(username);
        if (!this.containsUser(username) || !this.users[userIndex].isLogin) {
            throw new Error('You should be logged in to post answers');
        }

        if (answer === '') {
            throw new Error('Invalid answer');
        }

        if (!this.questions.some(x => x.has(questionId))) {
            throw new Error('There is no such question');
        }

        let idIndex = 0;

        for(let item of this.questions) {
            if (item.has(questionId)) {
                break;
            }
            idIndex++;
        }

        this.questions[idIndex].answer= answer;
        this.questions[idIndex].username = username;

        return 'Your answer has been posted successfully';
    }

    containsUser(username) {
       let contains = false;
       for(let item of this.users) {
           if (item.username === username) {
               contains = true;
               break;
           }
       }
       return contains;
    }

    match(username, password){
        return this.users.some(x => x.username === username && x.password === password);
    }

    getUsernameIndex(username) {
        return  this.users.findIndex(x => x.username === username);;
    }
}

let forum = new Forum();

console.log(forum.register('Michael', '123', '123', 'michael@abv.bg'));
console.log(forum.register('Stoyan', '123ab7', '123ab7', 'some@gmail@.com'));

console.log(forum.login('Michael', '123'));
console.log(forum.login('Stoyan', '123ab7'));

console.log(forum.postQuestion('Michael', "Can I rent a snowboard from your shop?"));
console.log(forum.postAnswer('Stoyan',1, "Yes, I have rented one last year."));
console.log(forum.postQuestion('Stoyan', "How long are supposed to be the ski for my daughter?"));
console.log(forum.postAnswer('Michael',2, "How old is she?"));
console.log(forum.postAnswer('Michael',2, "Tell us how tall she is."));

console.log(forum.showQuestions());