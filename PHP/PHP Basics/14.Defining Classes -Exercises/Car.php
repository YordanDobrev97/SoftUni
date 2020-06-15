<?php


class Car
{
    private $model;
    private $fuel_amount;
    private $fuel_cost_per_killometer;
    private $distance;

    public function __construct(string $model, float $fuel_amount, float $fuel_cost_per_killometer)
    {
        $this->setModel($model);
        $this->setFuelAmount($fuel_amount);
        $this->setFuelCostPerKillometer($fuel_cost_per_killometer);
        $this->setDistance(0);
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
     * @return float
     */
    public function getFuelAmount(): float
    {
        return $this->fuel_amount;
    }

    private function setFuelAmount(float $fuel_amount): void
    {
        $this->fuel_amount = $fuel_amount;
    }

    /**
     * @return float
     */
    public function getFuelCostPerKillometer(): float
    {
        return $this->fuel_cost_per_killometer;
    }

    private function setFuelCostPerKillometer(float $fuel_cost_per_killometer): void
    {
        $this->fuel_cost_per_killometer = $fuel_cost_per_killometer;
    }

    /**
     * @return int
     */
    public function getDistance(): int
    {
        return $this->distance;
    }

    private function setDistance(int $distance): void
    {
        $this->distance = $distance;
    }

    public function drive($distance): void
    {
        $fuel = round($distance * $this->fuel_cost_per_killometer, 2);

        if ($fuel <= round($this->fuel_amount, 2)) {
            $this->fuel_amount -= $fuel;
            $this->distance += $distance;
        } else {
            echo "Insufficient fuel for the drive".PHP_EOL;
        }
    }

    public function __toString()
    {
        return "$this->model " . number_format(abs($this->fuel_amount), 2, '.', '') . " $this->distance" . PHP_EOL;
    }
}

$number_cars = intval(readline());
$cars = [];

for ($i = 0; $i < $number_cars; $i++) {
    $car_data = explode(' ', trim(readline()));
    $model = $car_data[0];
    $fuel_amount = $car_data[1];
    $fuel_cost_per_killometer = $car_data[2];

    $car = new Car($model, $fuel_amount, $fuel_cost_per_killometer);
    array_push($cars, $car);
}

while (true) {
    $line = trim(readline());

    if ($line == 'End') {
        break;
    }

    $elements = explode(' ', $line);
    $car_model = $elements[1];
    $amount_of_km = $elements[2];

    foreach ($cars as $car) {
        if ($car_model == $car->getModel()) {
            $car->drive($amount_of_km);
        }
    }
}

foreach ($cars as $car) {
    echo $car;
}