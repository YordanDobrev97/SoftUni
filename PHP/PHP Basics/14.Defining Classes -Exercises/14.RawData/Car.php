<?php

class Engine
{
    private $engine_speed;
    private $engine_power;

    public function __construct(int $engine_speed, int $engine_power)
    {
        $this->engine_speed = $engine_speed;
        $this->engine_power = $engine_power;
    }

    /**
     * @return int
     */
    public function getEnginePower(): int
    {
        return $this->engine_power;
    }
}

class Cargo
{
    private $cargoWeight;
    private $cargoType;

    public function __construct(int $cargoWeight, string $cargoType)
    {
        $this->cargoWeight = $cargoWeight;
        $this->cargoType = $cargoType;
    }

    /**
     * @return string
     */
    public function getCargoType(): string
    {
        return $this->cargoType;
    }
}

class Tire
{
    private $tirePressure;
    private $tireAge;

    public function __construct(float $tirePressure, int $tireAge)
    {
        $this->tirePressure = $tirePressure;
        $this->tireAge = $tireAge;
    }

    public function isRightPressure()
    {
        return $this->tirePressure < 1;
    }
}

class Car
{
    private $model;
    private $engine;
    private $cargo;
    private $tires;

    public function __construct(string $model, Engine $engine, Cargo $cargo, array $tires)
    {
        $this->model = $model;
        $this->engine = $engine;
        $this->cargo = $cargo;
        $this->tires = $tires;
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @return Engine
     */
    public function getEngine(): Engine
    {
        return $this->engine;
    }

    /**
     * @return Cargo
     */
    public function getCargo(): Cargo
    {
        return $this->cargo;
    }

    /**
     * @return array
     */
    public function getTires(): array
    {
        return $this->tires;
    }
}

$count_cars = intval(readline());
$cars = [];

for ($i = 0; $i < $count_cars; $i++) {
    $elements = explode(' ', readline());
    list($model, $engine_speed, $engine_power, $cargo_weight,
        $cargo_type, $tire_pressure1, $tire_age1, $tire_pressure2, $tire_age2,
        $tire_pressure3, $tire_age3, $tire_pressure4, $tire_age4) = $elements;

    $engine = new Engine($engine_speed, $engine_power);
    $cargo = new Cargo($cargo_weight, $cargo_type);
    $tires[] = new Tire($tire_pressure1, $tire_age1);
    $tires[] = new Tire($tire_pressure2, $tire_age2);
    $tires[] = new Tire($tire_pressure3, $tire_age3);
    $tires[] = new Tire($tire_pressure4, $tire_age4);

    $car = new Car($model, $engine, $cargo, $tires);
    $cars[] = $car;

}

$command = trim(readline());

if ($command == 'fragile') {
    foreach ($cars as $car) {
        if ($car->getCargo()->getCargoType() == 'fragile') {
            foreach ($car->getTires() as $tire) {
                if ($tire->isRightPressure()) {
                    echo $car->getModel() . PHP_EOL;
                    break;
                }
            }
        }
    }
} else if ($command == 'flamable') {
    foreach ($cars as $car) {
        if ($car->getEngine()->getEnginePower() > 250) {
            echo $car->getModel() . PHP_EOL;
        }
    }
}