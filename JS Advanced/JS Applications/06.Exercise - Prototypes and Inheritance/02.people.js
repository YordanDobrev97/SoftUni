function solve() {
    class Employee {
        constructor(name, age) {
            if (new.target === Employee) {
                throw new Error('Cannot instantiable directly.')
            }
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
        }

        work(){
            const firstTask = this.tasks.shift();
            console.log(this.name + firstTask);
            this.tasks.push(firstTask);
        }

        collectSalary() {
            const currentSalary = this.getSalary();
            console.log(`${this.name} received ${currentSalary} this month.`);
        }

        getSalary() {
            return this.salary;
        }
    }

    class Junior extends Employee {
        constructor(name, age) {
            super(name, age);
            this.tasks.push(` is working on a simple task.`);
        }

        getSalary() {
            return this.salary;
        }
    }

    class Senior extends Employee {
        constructor(name, age) {
            super(name, age);
            this.tasks.push(` is working on a complicated task.`);
            this.tasks.push(` is taking time off work.`);
            this.tasks.push(` is supervising junior workers.`);
        }
    }

    class Manager extends Employee {
        constructor(name, age) {
            super(name, age);
            this.dividend = 0;
            this.tasks.push(` scheduled a meeting.`);
            this.tasks.push(` is preparing a quarterly report.`);
        } 

        getSalary() {
            return this.salary + this.dividend;
        }
    }

    return {
        Employee, Junior, Senior, Manager
    }
}

const Manager = solve().Manager;
const manager = new Manager('Pesho', 27);
manager.salary = 3000;
manager.dividend = 500;
console.log(manager.collectSalary());