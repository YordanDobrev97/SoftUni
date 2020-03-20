const baseUrl = 'https://students-e74e2.firebaseio.com/.json';

document.querySelector('.new-student').addEventListener('click', getStudentData);
document.querySelector('.load-students').addEventListener('click', loadStudents);

function getStudentData(e) {
    e.preventDefault();

    const firstName = document.querySelector('.first-name');
    const lastName = document.querySelector('.last-name');
    const facultyNumber = document.querySelector('.faculty-number');
    const grade = document.querySelector('.grade');

    if (!facultyNumber.value || !grade.value) {
        const red = '#FF0000';
        createDivMessage('required', 'All fields are required!', red, 900);
        return;
    }
    const studentObject = {
        firstName: firstName.value,
        lastName: lastName.value,
        facultyNumber: facultyNumber.value,
        grade: grade.value
    }

    fetch(baseUrl, {
        method: 'POST',
        body: JSON.stringify(studentObject)
    }).then(() => {
        const green = '#00ff00'
        createDivMessage('success-id', 'Success', green, 1000)
        firstName.value = '';
        lastName.value = '';
        facultyNumber.value = '';
        grade.value = '';
    });
}

function createDivMessage(nameClass, textContent, color, time) {
    const messageDiv = document.createElement('div');
    messageDiv.className = nameClass;
    messageDiv.textContent = textContent;
    messageDiv.style.color = color;
    messageDiv.style.display = 'center;'

    document.body.appendChild(messageDiv);
    setTimeout(() => {
        document.getElementsByClassName(nameClass)[0].remove();
    }, time);
}

function loadStudents() {
    const tableBody = document.querySelector('tbody');

    tableBody.innerHTML = '';

    let uniqueId = 1;
    fetch(baseUrl)
        .then(request => request.json())
        .then(data => {
            const students = Object.values(data);
            students.forEach(student => {
                const firstName = student.firstName;
                const lastName = student.lastName;
                const facultyNumber = student.facultyNumber;
                const grade = student.grade;

                const tr = document.createElement('tr');
                const tdId = document.createElement('td');
                const tdFirstName = document.createElement('td');
                const tdLastName = document.createElement('td');
                const tdFacultyNumber = document.createElement('td');
                const tdGrade = document.createElement('td');
                
                tdId.textContent = uniqueId;
                tdFirstName.textContent = firstName;
                tdLastName.textContent = lastName;
                tdFacultyNumber.textContent = facultyNumber;
                tdGrade.textContent = grade;

                tr.appendChild(tdId);
                tr.appendChild(tdFirstName);
                tr.appendChild(tdLastName);
                tr.appendChild(tdFacultyNumber);
                tr.appendChild(tdGrade);

                tableBody.appendChild(tr);
                uniqueId++;
            }); 
        })
}