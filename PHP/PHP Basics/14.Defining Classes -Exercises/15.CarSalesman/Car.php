<?php
/***
 * @param array $collection
 * @param string $engine
 * @return null
 */
function get_engine(array $collection, string $engine) {
    foreach ($collection as $data){
        if ($data->getModel() == $engine){
            return $data;
        }
    }
    return null;
}

class Engine
{
    private $model;
    private $power;
    private $displacement;
    private $efficiency;

    public function __construct(string $model, int $power, int $displacement = NULL, string $efficiency = NULL)
    {
        $this->setModel($model);
        $this->setPower($power);
        $this->setDisplacement($displacement);
        $this->setEfficiency($efficiency);
    }

    /**
     * @return mixed
     */
    public function getModel()
    {
        return $this->model;
    }

    private function setModel($model): void
    {
        $this->model = $model;
    }

    /**
     * @return mixed
     */
    public function getPower()
    {
        return $this->power;
    }

    private function setPower($power): void
    {
        $this->power = $power;
    }

    /**
     * @return mixed
     */
    public function getDisplacement()
    {
        return $this->displacement;
    }

    private function setDisplacement($displacement): void
    {
        $this->displacement = $displacement;
    }

    /**
     * @return mixed
     */
    public function getEfficiency()
    {
        return $this->efficiency;
    }

    private function setEfficiency($efficiency): void
    {
        $this->efficiency = $efficiency;
    }

    public function __toString()
    {
        $result = "  " . $this->getModel() . ":" . PHP_EOL;
        $result .= "    Power: " . $this->getPower() . PHP_EOL;

        if ($this->getDisplacement()) {
            $result .= "    Displacement: " . $this->getDisplacement() . PHP_EOL;
        }  else {
            $result .= "    Displacement: n/a" . PHP_EOL;
        }

        if ($this->getEfficiency()) {
            $result .= "    Efficiency: " . $this->getEfficiency();
        } else {
            $result .= "    Efficiency: n/a";
        }

        return $result;
    }
}

class Car
{
    private $model;
    private $engine;
    private $weight;
    private $color;

    public function __construct(string $model, Engine $engine, int $weight = NULL, string $color = NULL)
    {
        $this->setModel($model);
        $this->setEngine($engine);
        $this->setWeight($weight);
        $this->setColor($color);
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    private function setModel(string $model): void
    {
        $this->model = $model;
    }

    /**
     * @return Engine
     */
    public function getEngine(): Engine
    {
        return $this->engine;
    }

    private function setEngine(Engine $engine): void
    {
        $this->engine = $engine;
    }

    /**
     * @return int|null
     */
    public function getWeight(): ?int
    {
        return $this->weight;
    }

    private function setWeight(?int $weight): void
    {
        $this->weight = $weight;
    }

    /**
     * @return string|null
     */
    public function getColor(): ?string
    {
        return $this->color;
    }

    private function setColor(?string $color): void
    {
        $this->color = $color;
    }

    public function __toString()
    {
       $result = $this->getModel() . ":" . PHP_EOL;
       $result .= $this->getEngine() . PHP_EOL;
       if ($this->getWeight()) {
           $result .= "  Weight: " . $this->getWeight() . PHP_EOL;
       } else {
           $result .= "  Weight: n/a" . PHP_EOL;
       }

       if ($this->getColor()) {
           $result .= "  Color: " . $this->getColor() . PHP_EOL;
       } else {
           $result .= "  Color: n/a"  . PHP_EOL;
       }

       return $result;
    }
}

$count_engines = intval(readline());

$engines = [];

for ($i = 0; $i < $count_engines; $i++) {
    $engine_data = explode(' ', readline());
    $model = $engine_data[0];
    $power = $engine_data[1];

    if (count($engine_data) == 4) {
        $displacement = $engine_data[2];
        $efficiency = $engine_data[3];
        $engine = new Engine($model, intval($power), intval($displacement), $efficiency);
        $engines[] = $engine;
    } else if (count($engine_data) == 3) {
        if (is_numeric($engine_data[2])) {
            $displacement = $engine_data[2];
            $engine = new Engine($model, intval($power), intval($displacement), NULL);
            $engines[] = $engine;
        } else {
            $efficiency = $engine_data[2];
            $engine = new Engine($model, intval($power), NULL, $efficiency);
            $engines[] = $engine;
        }
    } else if (count($engine_data) == 2) {
        $engine = new Engine($model, intval($power), NULL, NULL);
        $engines[] = $engine;
    }
}

$count_cars = intval(readline());

$cars = [];
for ($i = 0; $i < $count_cars; $i++) {
    $car_data = explode(' ', readline());
    $model = $car_data[0];
    $engine = $car_data[1];

    $found_engine = get_engine($engines, $engine);

    if (count($car_data) == 4) {
        $weight = $car_data[2];
        $color = $car_data[3];
        $car = new Car($model, $found_engine, intval($weight), $color);
        $cars[] = $car;
    } else if (count($car_data) == 3) {
        if (is_numeric($car_data[2])) {
            $weight = $car_data[2];
            $car = new Car($model, $found_engine, intval($weight), NULL);
            $cars[] = $car;
        } else {
            $color = $car_data[2];
            $car = new Car($model, $found_engine, NULL, $color);
            $cars[] = $car;
        }
    } else if (count($car_data) == 2) {
        $car = new Car($model, $found_engine, NULL, NULL);
        $cars[] = $car;
    }
}

foreach ($cars as $car) {
    echo $car;
}