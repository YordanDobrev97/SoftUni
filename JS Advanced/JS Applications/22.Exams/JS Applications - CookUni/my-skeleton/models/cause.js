export default {
    cause: {
        create(data) {
           return firebase.firestore().collection('recipes').add(data);
        },
        getAll() {
            return firebase.firestore().collection('recipes').get();
        },
        getById(id) {
            return firebase.firestore().collection('recipes').doc(id).get();
        }
    }
}