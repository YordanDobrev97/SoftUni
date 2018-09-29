<?php
//declare(strickt_types=1);

class Person{
    public $name;
    
    public function __construct($name) {
        $this->name = $name;
    }
    
    function greeting(){
        $result = $this->name." says \"Hello\"!"; 
        return $result;
    }
}

$person = new Person('Pesho');
echo $person->greeting()."<br>";
        
$person2 = new Person('Gosho');
echo $person2->greeting();

?>

