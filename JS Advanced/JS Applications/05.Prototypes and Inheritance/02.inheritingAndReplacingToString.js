function personAndTeacher() {
    class Person {
        constructor(name, email) {
            this.name = name;
            this.email = email;
        }

        toString() {
            const className = this.constructor.name;
            return `${className} (name: ${this.name}, email: ${this.email})`;
        }
    }

    class Teacher extends Person {
        constructor(name, email, subject) {
            super(name, email);
            this.subject = subject;
        }

        toString() {
            let className = super.toString();
            className = className.slice(0, className.length - 1);
            return `${className}, subject: ${this.subject})`;
        }
    }

    class Student extends Person {
        constructor(name, email, course) {
            super(name, email);
            this.course = course;
        }

        toString() {
            let className = super.toString();
            className = className.slice(0, className.length - 1);
            return `${className}, course: ${this.course})`;
        }
    }

    return {
        Person,
        Teacher,
        Student
    }
}

const result = personAndTeacher();
const Teacher = result.Teacher;

let t = new Teacher("Gosho",'gosh@gosh.com',"Graphics");
console.log(t.toString());
//Teacher (name: Gosho, email: gosh@gosh.com, subject: Graphics)
