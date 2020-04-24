const events = require('events');

const emmiter = new events.EventEmitter();
emmiter.on('click', console.log);

const softUniCourses = ['Data Structures', 'Algorithms', 'JS Fundamentals', 'JS Back-End', 'React'];
let indexCourse = 0;

setInterval(function() {
    if (softUniCourses[indexCourse]) {
        emmiter.emit('click', softUniCourses[indexCourse++]);
    }
}, 2000);