class EventEmitter {
    constructor() {
        this.events = {};
    }

    subscription(nameOfSubscription, callback) {
        if (!this.events.hasOwnProperty(nameOfSubscription)) {
            this.events[nameOfSubscription] = [];
        }

        this.events[nameOfSubscription].push(callback);
    }

    emit(nameOfSubscription, data) {
        if (!this.events.hasOwnProperty(nameOfSubscription)) {
            throw new Error(`Not contains this event: ${nameOfSubscription}`);
        }

        this.events[nameOfSubscription].forEach(callback => {
            callback(data);
        });
    }
}

const emitter = new EventEmitter();

emitter.subscription('has concert of Eminem', getMoney);
emitter.subscription('has concert of 50cent', inviteFriends);

emitter.emit('has concert of Eminem', 'get money');
emitter.emit('has concert of 50cent', 'Invite: Pesho, Gosho, Ivan');

function getMoney(data) {
    console.log(data);
}

function inviteFriends(data) {
    console.log(data);
}