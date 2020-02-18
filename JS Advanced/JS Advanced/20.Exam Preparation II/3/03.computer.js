class Computer {
    constructor(ramMemory, cpuGHz, hddMemory) {
        this.ramMemory = ramMemory;
        this.cpuGHz = cpuGHz;
        this.hddMemory = hddMemory;
        this.taskManager = [];
        this.installedPrograms = [];
    }

    installAProgram(name, requiredSpace) {
        if (this.hddMemory - requiredSpace < 0) {
            throw new Error('There is not enough space on the hard drive');
        }

        const newProgram = {
            name,
            requiredSpace
        };

        this.installedPrograms.push(newProgram);
        this.hddMemory -= requiredSpace;
        return newProgram;
    }

    uninstallAProgram(name) {
        if (!this.installedPrograms.some(x => x.name === name)) {
            throw new Error('Control panel is not responding');
        }

        const program = this.installedPrograms.find(x => x.name === name);
        this.installedPrograms = this.installedPrograms.filter(x => x.name !== program.name);
        this.hddMemory += program.requiredSpace;
        return this.installedPrograms;
    }

    openAProgram(name) {
        this.throwErrorIfNotContains(name);
        this.throwErrorAlreadyOpen(name);

        const program = this.installedPrograms.find(x => x.name === name);
        const usageRam = (program.requiredSpace / this.ramMemory) * 1.5;
        const usageCpu = ((program.requiredSpace / this.cpuGHz) / 500) * 1.5;

        if (this.ramTotalUsage >= 100) {
            throw new Error(`${name} caused out of memory exception`);
        }

        if (this.cpuTotalUsage >= 100) {
            throw new Error(`${name} caused out of cpu exception`)
        }

        const programObject = {
            name,
            ramUsage: usageRam,
            cpuUsage: usageCpu
        };

        this.taskManager.push(programObject);
        return programObject;
    }

    taskManagerView(){
        if (this.taskManager.length === 0) {
            return 'All running smooth so far';
        }

        let result = '';
        for(let item of this.taskManager) {
            result += `Name - {item.name} | Usage - CPU: {item.cpuUsage}%, RAM: {item.ramUsage}%\n`;
        }
        return result;
    }

    throwErrorAlreadyOpen(name) {
        if (this.taskManager.includes(name)) {
            throw new Error(`The ${name} is already open`);
        }
    }

    throwErrorIfNotContains(name) {
        if (!this.installedPrograms.some(x => x.name === name)) {
            throw new Error(`The ${name} is not recognized`);
        }
    }

    get ramTotalUsage() {
        return this.taskManager.reduce((acc, current) => acc + current.ramUsage, 0);
    }

    get cpuTotalUsage() {
        return this.taskManager.reduce((acc, current) => acc + current.cpuUsage, 0);
    }
}

let computer = new Computer(4096, 7.5, 250000);

computer.installAProgram('Word', 7300);
computer.installAProgram('Excel', 10240);
computer.installAProgram('PowerPoint', 12288);
computer.uninstallAProgram('Word');
computer.installAProgram('Solitare', 1500);

computer.openAProgram('Excel');
computer.openAProgram('Solitare');

console.log(computer.installedPrograms);
console.log(('-').repeat(50)) // Separator
console.log(computer.taskManager);

