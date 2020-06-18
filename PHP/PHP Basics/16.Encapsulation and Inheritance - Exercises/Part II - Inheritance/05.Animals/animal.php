<?php
class Constants
{
    private const MESSAGE_ERROR_INVALID_INPUT = 'Invalid input!';

    public static function invalidInput()
    {
        return self::MESSAGE_ERROR_INVALID_INPUT;
    }
}

abstract class Animal
{
    private $name;
    private $age;
    private $gender;
    private $type;

    public function __construct($name,  $age, $gender, $type = 'Animal')
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setGender($gender);
        $this->type = $type;
    }

    public function getName()
    {
        return $this->name;
    }

    public function getAge()
    {
        return $this->age;
    }

    public function getGender()
    {
        return $this->gender;
    }

    private function setName($name): void
    {
        if (empty($name)) {
            throw new Exception(Constants::invalidInput());
        }
        $this->name = $name;
    }

    private function setAge($age): void
    {
        if ($age < 0) {
            throw new Exception(Constants::invalidInput());
        }
        $this->age = $age;
    }

    private function setGender($gender): void
    {
        if (empty($gender)) {
            throw new Exception(Constants::invalidInput());
        }

        $this->gender = $gender;
    }

    public abstract function produceSound() : string;

    public function __toString()
    {
      return $this->type . ' ' . $this->getName() . ' ' . $this->getAge() . ' ' . $this->getGender();
    }
}

class Cat extends Animal
{
    private const CAT_SOUND = 'MiauMiau';
    private const TYPE = 'Cat';

    public function __construct($name, $age, $gender)
    {
        parent::__construct($name, $age, $gender, self::TYPE);
    }

    public function produceSound(): string
    {
        return self::CAT_SOUND;
    }
}

class Dog extends Animal
{
    private const DOG_SOUND = 'BauBau';
    private const TYPE = 'Dog';

    public function __construct($name, $age, $gender)
    {
        parent::__construct($name, $age, $gender, self::TYPE);
    }

    public function produceSound(): string
    {
        return self::DOG_SOUND;
    }
}

class Frog extends Animal
{
    private const FROG_SOUND = 'Frogggg';
    private const TYPE = 'Frog';

    public function __construct($name, $age, $gender)
    {
        parent::__construct($name, $age, $gender, self::TYPE);
    }

    public function produceSound(): string
    {
        return self::FROG_SOUND;
    }
}

class Kitten extends Cat
{
    private const KITTEN_SOUND = 'Miau';
    private const TYPE = 'Kitten';

    public function __construct($name, $age, $gender)
    {
        parent::__construct($name, $age, $gender, self::TYPE);
    }

    public function produceSound(): string
    {
        return self::KITTEN_SOUND;
    }
}

class Tomcat extends Dog
{
    private const TOMCAT_SOUND = 'Give me one million b***h';
    private const TYPE = 'Tomcat';

    public function __construct($name, $age, $gender)
    {
        parent::__construct($name, $age, $gender, self::TYPE);
    }

    public function produceSound(): string
    {
        return self::TOMCAT_SOUND;
    }
}

class AnimalFactory
{
    public function create($type, $data) : Animal {
        list($name, $age, $gender) = $data;
        if ($type == 'Cat') {
            return new Cat($name, $age, $gender);
        } else if ($type == 'Dog') {
            return new Dog($name, $age, $gender);
        } else if ($type == 'Frog') {
            return new Frog($name, $age, $gender);
        } else if ($type == 'Tomcat') {
            return new Tomcat($name, $age, $gender);
        } else if ($type == 'Kitten') {
            return new Kitten($name, $age, $gender);
        }

        throw new Exception(Constants::invalidInput());
    }
}

while (true) {
    $line = readline();

    if ($line == 'Beast!') {
        break;
    }

    try {
        $type = $line;
        $animal = explode(' ', readline());
        $animal_factory = new AnimalFactory();
        $animal_result = $animal_factory->create($type, $animal);
        echo $animal_result . PHP_EOL;
        echo $animal_result->produceSound() . PHP_EOL;
    } catch (Exception $e) {
        echo $e->getMessage() . PHP_EOL;
        return;
    }
}
?>