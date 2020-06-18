<?php
class Constants
{
    private const MESSAGE_EMPTY_NAME = 'Name cannot be empty';
    private const MESSAGE_NEGATIVE_COST = 'Money cannot be negative';

    public static function throwExceptionIfEmptyName($name) {
        if (empty($name)) {
            throw new Exception(self::MESSAGE_EMPTY_NAME);
        }
    }

    public static function throwExceptionIfNegativeMoney($money) {
        if ($money < 0) {
            throw new Exception(self::MESSAGE_NEGATIVE_COST);
        }
    }
}

class Person
{
    private $name;
    private $money;
    private $products = [];

    public function __construct($name, $money)
    {
        $this->setName($name);
        $this->setMoney($money);
    }

    public function getName()
    {
        return $this->name;
    }

    public function getMoney()
    {
        return $this->money;
    }

    public function getProducts()
    {
        return $this->products;
    }

    public function addProduct($product) {
        $this->products[] = $product;
    }

    public function decreaseMoney($quantity) {
        $this->money -= $quantity;
    }

    private function setName($name): void
    {
        Constants::throwExceptionIfEmptyName($name);
        $this->name = $name;
    }

    private function setMoney($money): void
    {
        Constants::throwExceptionIfNegativeMoney($money);
        $this->money = $money;
    }

    public function __toString()
    {
        $result = $this->getName() . ' - ';

        $count = 1;
        $total = count($this->getProducts());

        if ($total == 0) {
            $result .= 'Nothing bought';
        }

        foreach ($this->getProducts() as $product) {
            $result .= $product->getName();

            if ($count++ < $total) {
                $result .= ',';
            }
        }
        return $result;
    }
}

class Product
{
    private $name;
    private $cost;

    public function __construct($name, $cost)
    {
        $this->setName($name);
        $this->setCost($cost);
    }

    public function getName()
    {
        return $this->name;
    }

    public function getCost()
    {
        return $this->cost;
    }

    private function setName($name): void
    {
        Constants::throwExceptionIfEmptyName($name);
        $this->name = $name;
    }

    private function setCost($cost): void
    {
        Constants::throwExceptionIfNegativeMoney($cost);
        $this->cost = $cost;
    }
}

$people_input = explode(';', trim(readline()));
$product_input = explode(';', readline());

try {
    $people = processInputPeople($people_input);
    $products = processInputProducts($product_input);

    while (true) {
        $line = readline();

        if ($line == 'END') {
            break;
        }

        list($person, $product) = explode(' ', $line);
        $current_person = $people[$person];
        $current_product = $products[$product];

        $money_person = $current_person->getMoney();
        $money_product = $current_product->getCost();

        if ($money_product > $money_person) {
            echo "$person can't afford $product" . PHP_EOL;
        } else {
            echo "$person bought $product" . PHP_EOL;
            $current_person->addProduct($current_product);
            $current_person->decreaseMoney($money_product);
        }
    }

    foreach ($people as $person) {
        echo $person . PHP_EOL;
    }
} catch (Exception $e) {
    echo $e->getMessage() . PHP_EOL;
}

function processInputPeople(array $input) {
    $result = [];

    foreach ($input as $item) {
        $parts = explode('=', $item);
        $name = $parts[0];
        $money = floatval($parts[1]);

        if ($name != '') {
            $person = new Person($name, $money);
            $result[$name] = $person;
        }
    }

    return $result;
}

function processInputProducts(array $input) {
    $result = [];

    foreach ($input as $item) {
        list($name, $cost) = explode('=', $item);
        if ($name != '') {
            $product = new Product($name, $cost);
            $result[$name] = $product;
        }
    }

    return $result;
}
?>