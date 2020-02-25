class Company {
    constructor() {
        this.departments = [];
    }
    addEmployee(username, salary, position, department) {
        if (!username || !salary || !position || !department || salary < 0) {
            throw new Error('Invalid input!');
        }

        let currentDepartment = this.departments.find(x => x.department === department);
        if (!currentDepartment) {
           currentDepartment = {
              department: department,
              employees: []
           };
           this.departments.push(currentDepartment);
        }

        currentDepartment.employees.push({
            username,
            salary,
            position
        });

        return `New employee is hired. Name: ${username}. Position: ${position}`;
    }

    bestDepartment() {
        let departmentName = '';
        let maxSalary = 0;
        let employees = [];

        for(let department of this.departments) {
            const sumSalary = department.employees.reduce((prev, current) => prev + current.salary, 0);
            const avg = sumSalary / department.employees.length;

            if (avg > maxSalary) {
                maxSalary = avg;
                departmentName = department.department;
                employees = [];
                employees.push(department.employees);
            }
        }

        let output = `Best Department is: ${departmentName}\n`;
        output += `Average salary: ${maxSalary.toFixed(2)}\n`;
        const sorted = employees[0].sort((a,b) => {
            if (a.salary === b.salary) {
                return a.username.localeCompare(b.username);
            }
            return b.salary - a.salary
        });

        let count = 0;
        const totalLength = employees[0].length;
        for(let employee of employees[0]) {
            if (count < totalLength - 1) {
                output += `${employee.username} ${employee.salary} ${employee.position}\n`;
            } else {
                output += `${employee.username} ${employee.salary} ${employee.position}`;
            }            
            count++;
        }
        return output;
    }
}

let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());


