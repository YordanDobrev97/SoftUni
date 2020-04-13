export default {
    register(username, password) {
       return firebase.auth().createUserWithEmailAndPassword(username, password);
    },
    login(username, password) {
        return firebase.auth().signInWithEmailAndPassword(username, password);
    },
    logout() {
        console.log('work');
        sessionStorage.clear();
        return firebase.auth().signOut();
    }
}