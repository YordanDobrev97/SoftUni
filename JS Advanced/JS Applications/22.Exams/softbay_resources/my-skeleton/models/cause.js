export default {
    cause: {
        create(data) {
           return firebase.firestore().collection('offers').add(data);
        },
        getAll() {
            return firebase.firestore().collection('offers').get();
        },
        getById(id) {
            return firebase.firestore().collection('offers').doc(id).get();
        },
        remove(id) {
            return firebase.firestore().collection('offers').doc(id).delete();
        }
    }
}