export default {
    cause: {
        create(data) {
           return firebase.firestore().collection('causes').add(data);
        },
        getAll() {
            return firebase.firestore().collection('causes').get();
        },
        getById(id) {
            return firebase.firestore().collection('causes').doc(id).get();
        },
        close(id) {
            return firebase.firestore().collection('causes').doc(id).delete();
        }
    }
}