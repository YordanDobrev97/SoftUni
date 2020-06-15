<?php

class Person
{
    private $name;
    private $age;

    public function __construct($name, $age)
    {
        $this->name = $name;
        $this->age = $age;
    }

    /**
     * @return mixed
     */
    public function getAge()
    {
        return $this->age;
    }

    /**
     * @return mixed
     */
    public function getName()
    {
        return $this->name;
    }

    public function __toString()
    {
        return $this->getName() . ' - ' . $this->getAge();
    }
}

$count_lines = intval(readline());
$persons = [];

for ($i = 0; $i < $count_lines; $i++) {
    $person_data = explode(' ', readline());
    $name = $person_data[0];
    $age = intval($person_data[1]);

    if ($age > 30) {
        $person = new Person($name, $age);
        array_push($persons, $person);
    }
}

usort($persons, function ($p1, $p2) {
    return $p1->getName() <=> $p2->getName();
});

foreach ($persons as $person) {
    $age = $person->getAge();
    echo $person.PHP_EOL;
}