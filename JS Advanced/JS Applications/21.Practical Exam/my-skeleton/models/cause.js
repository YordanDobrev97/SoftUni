export default {
    cause: {
        create(data) {
            return firebase.firestore().collection('wiki').add(data);
        },
        getAll() {
            return firebase.firestore().collection('wiki').get();
        },
        getById(id) {
            return firebase.firestore().collection('wiki').doc(id).get();
        },
        remove(id) {
            return firebase.firestore().collection('wiki').doc(id).delete();
        }
    }
}