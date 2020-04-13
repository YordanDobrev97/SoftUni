export default {
    cause: {
        create(data) {
            return firebase.firestore().collection('treaks').add(data);
        },
        getAll() {
            return firebase.firestore().collection('treaks').get();
        },
        getById(id) {
            return firebase.firestore().collection('treaks').doc(id).get();
        }
    }
}