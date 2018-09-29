<?php
//declare (strick_types=1);
class Person{
    public $name;
    public $age;
    public $occupation;
    
    public function __construct(string $name, int $age,string $occupation) {
        $this->name = $name;
        $this->age = $age;
        $this->occupation = $occupation;
    }
    
    function printInfoPerson():string {
        return "Name: ".$this->name.", Age: ".$this->age.", Occupation: ".$this->occupation."<br>";  
    }
}

$number_people = 3;

for($i = 0; $i < $number_people; $i++){
    $newPerson = new Person('Pesho', $i, 'PHP Develper');
    echo $newPerson->printInfoPerson();
}
?>

