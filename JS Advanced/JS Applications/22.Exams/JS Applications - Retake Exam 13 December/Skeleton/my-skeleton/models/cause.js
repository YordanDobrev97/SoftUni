export default {
    cause: {
        create(data) {
            return firebase.firestore().collection('ideas').add(data);
        },
        getAll() {
            return firebase.firestore().collection('ideas').get();
        },
        getById(id) {
            return firebase.firestore().collection('ideas').doc(id).get();
        },
        remove(id) {
            return firebase.firestore().collection('ideas').doc(id).delete();
        }
    }
}