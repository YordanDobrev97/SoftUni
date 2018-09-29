<?php

class Person{
    private $name;
    private $age;
    
    public function __construct($name, $age) {
        $this->name = $name;
        $this->age = $age; 
    }
    
    public function getName(){
        return $this->name;
    }

    public function setName($value){
        $this->name = $value;
    }
    
    public function getAge(){
        return $this->age;
    }
    public function setAge($value){
        $this->age = $value;
    }
}

$pesho = new Person("Pesho", 19);

echo $pesho->getName()."<br>";
echo $pesho->getAge()."<br>";
?>

