<?php

class Employee
{
    private $name;
    private $salary;
    private $position;
    private $department;
    private $email;
    private $age;

    public function __construct($name, $salary, $position, $department, $email = NULL, $age = NULL)
    {
        $this->name = $name;
        $this->salary = $salary;
        $this->position = $position;
        $this->department = $department;
        $this->email = $email;
        $this->age = $age;
    }

    /**
     *
     */
    public function getSalary()
    {
        return $this->salary;
    }

    /**
     * @return null
     */
    public function getEmail()
    {
        return $this->email;
    }

    /**
     * @return int
     */
    public function getAge()
    {
        return $this->age;
    }

    private function get_format_age()
    {
        if ($this->age) {
            return "$this->age";
        } else {
            return "-1";
        }
    }

    private function get_format_email()
    {
        if ($this->email) {
            return "$this->email";
        } else {
            return "n/a";
        }
    }
    public function __toString()
    {
        return $this->name . ' ' . number_format($this->getSalary(), 2) .
            ' ' . $this->get_format_email() . ' ' . $this->get_format_age();
    }
}

$count_lines = intval(readline());
$employees = [];

for ($i = 0; $i < $count_lines; $i++) {
    $employee_data = explode(' ', readline());
    $name = $employee_data[0];
    $salary = floatval($employee_data[1]);
    $position = $employee_data[2];
    $department = $employee_data[3];

    if (count($employee_data) == 4) {
        $employee = new Employee($name, $salary, $position, $department);
        $employees = add_employee($employees, $employee, $department);
    } else if (count($employee_data) == 6) {
        $email = $employee_data[4];
        $age = intval($employee_data[5]);
        $employee = new Employee($name, $salary, $position, $department, $email, $age);
        $employees = add_employee($employees, $employee, $department);
    } else if (is_numeric($employee_data[4])) {
        $age = intval($employee_data[4]);
        $employee = new Employee($name, $salary, $position, $department, null, $age);
        $employees = add_employee($employees, $employee, $department);
    } else {
        $email = $employee_data[4];
        $employee = new Employee($name, $salary, $position, $department, $email);
        $employees = add_employee($employees, $employee, $department);
    }
}

function add_employee($collection, $data, $key) {
    if (!key_exists($key, $collection)) {
        $collection[$key][] = $data;
    } else {
        $collection[$key][] = $data;
    }
    return $collection;
}

$max_avg_salary = 0;
$employee_max_salary = null;
$department_max_salary = '';
foreach ($employees as $department => $department_employees) {
    $max_salaries = 0.0;
    foreach ($department_employees as $current_employee) {
        $max_salaries += $current_employee->getSalary();
    }

    $avg = $max_salaries / count($department_employees);

    if ($max_avg_salary < $avg) {
        $max_avg_salary = $avg;
        $employee_max_salary = $department_employees;
        $department_max_salary = $department;
    }
}

usort($employee_max_salary, function ($emp1, $emp2) {
    return $emp2->getSalary() - $emp1->getSalary();
});

echo 'Highest Average Salary: '. $department_max_salary.PHP_EOL;
foreach ($employee_max_salary as $item) {
    echo $item.PHP_EOL;
}