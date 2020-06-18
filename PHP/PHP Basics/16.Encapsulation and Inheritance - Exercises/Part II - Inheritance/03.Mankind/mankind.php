<?php
class Human
{
    private const MESSAGE_ERROR_FIRST_NAME_UPPER = 'Expected upper case letter!Argument: firstName';
    private const MESSAGE_ERROR_FIRST_NAME_LENGTH = 'Expected length at least 4 symbols!Argument: firstName';
    private const MESSAGE_ERROR_LAST_NAME_UPPER = 'Expected upper case letter!Argument: lastName';
    private const MESSAGE_ERROR_LAST_NAME_LENGTH = 'Expected length at least 3 symbols!Argument: lastName ';

    private $firstName;
    private $lastName;

    public function __construct($firstName, $lastName)
    {
        $this->setFirstName($firstName);
        $this->setLastName($lastName);
    }

    public function getFirstName()
    {
        return $this->firstName;
    }

    public function getLastName()
    {
        return $this->lastName;
    }

    protected function setFirstName($firstName): void
    {
        if (!ctype_upper($firstName[0])) {
            throw new Exception(self::MESSAGE_ERROR_FIRST_NAME_UPPER);
        }

        if (strlen($firstName) < 4) {
            throw new Exception(self::MESSAGE_ERROR_FIRST_NAME_LENGTH);
        }

        $this->firstName = $firstName;
    }

    protected function setLastName($lastName): void
    {
        if (!ctype_upper($lastName[0])) {
            throw new Exception(self::MESSAGE_ERROR_LAST_NAME_UPPER);
        }

        if (strlen($lastName) < 3) {
            throw new Exception(self::MESSAGE_ERROR_LAST_NAME_LENGTH);
        }

        $this->lastName = $lastName;
    }

    public function __toString()
    {
       $result = 'First Name: ' . $this->getFirstName() . PHP_EOL;
       $result .= 'Last Name: ' . $this->getLastName() . PHP_EOL;

       return $result;
    }
}

class Student extends Human
{
    private const MESSAGE_ERROR_FACULTY_NUMBER = 'Invalid faculty number!';

    private $facultyNumber;

    public function __construct($firstName, $lastName, $facultyNumber)
    {
        parent::__construct($firstName, $lastName);
        $this->setFacultyNumber($facultyNumber);
    }

    public function getFacultyNumber()
    {
        return $this->facultyNumber;
    }

    private function setFacultyNumber($facultyNumber): void
    {
        if (strlen($facultyNumber) < 5 || strlen($facultyNumber) > 10) {
            throw new Exception(self::MESSAGE_ERROR_FACULTY_NUMBER);
        }

        $this->facultyNumber = $facultyNumber;
    }

    public function __toString()
    {
        $result = parent::__toString();
        $result .= 'Faculty number: ' . $this->getFacultyNumber() . PHP_EOL;
        return $result;
    }
}

class Worker extends Human
{
    private const MESSAGE_ERROR_SALARY = 'Expected value mismatch!Argument: weekSalary';
    private const MESSAGE_ERROR_HOURS = 'Expected value mismatch!Argument: workHoursPerDay';
    private const DAYS_WEEK = 7;

    private $salary;
    private $hours;

    public function __construct($firstName, $lastName, $salary, $hours)
    {
        parent::__construct($firstName, $lastName);
        $this->setSalary($salary);
        $this->setHours($hours);
    }

    public function getSalary()
    {
        return $this->salary;
    }

    public function getHours()
    {
        return $this->hours;
    }

    private function setSalary($salary): void
    {
        if ($salary < 10) {
            throw new Exception(self::MESSAGE_ERROR_SALARY);
        }
        $this->salary = $salary;
    }

    private function setHours($hours): void
    {
        if ($hours < 1 || $hours > 12) {
            throw new Exception(self::MESSAGE_ERROR_HOURS);
        }
        $this->hours = $hours;
    }

    public function __toString()
    {
        $result = parent::__toString();
        $result .= 'Week Salary: ' . number_format($this->getSalary(), 2, '.', '') . PHP_EOL;
        $result .= 'Hours per day: ' . number_format($this->getHours(), 2, '.', '') . PHP_EOL;
        $result .= 'Salary per hour: ' . number_format($this->getSalary() / (self::DAYS_WEEK * $this->getHours()), 2 , '.', '');

        return $result;
    }
}

$student_input = explode(' ', readline());
$worker_input = explode(' ', readline());

list($firstName, $lastName, $facultyNumber) = $student_input;
list($firstNameWorker, $lastNameWorker, $salary, $hours) = $worker_input;

try {
    $student = new Student($firstName, $lastName, $facultyNumber);
    $worker = new Worker($firstNameWorker, $lastNameWorker, $salary, $hours);

    echo $student . PHP_EOL;
    echo $worker . PHP_EOL;
} catch (Exception $e) {
    echo $e->getMessage() . PHP_EOL;
}
?>