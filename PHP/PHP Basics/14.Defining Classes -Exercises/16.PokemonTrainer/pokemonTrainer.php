<?php

class Pokemon
{
    private $name;
    private $element;
    private $health;

    public function __construct(string $name, string $element, int $health)
    {
        $this->setName($name);
        $this->setElement($element);
        $this->setHealth($health);
    }

    /**
     * @return string
     */
    public function getName() : string
    {
        return $this->name;
    }

    private function setName($name): void
    {
        $this->name = $name;
    }

    /**
     * @return string
     */
    public function getElement() : string
    {
        return $this->element;
    }

    private function setElement($element): void
    {
        $this->element = $element;
    }

    /**
     * @return int
     */
    public function getHealth() : int
    {
        return $this->health;
    }

    public function decreaseHealth(int $value) {
        $this->health -= $value;
    }

    /**
     * @param mixed $health
     */
    private function setHealth($health): void
    {
        $this->health = $health;
    }
}

class Trainer
{
    private $name;
    private $number_of_batches;
    private $pokemons;

    public function __construct(string $name, Pokemon $pokemon)
    {
        $this->setName($name);
        $this->addPokemon($pokemon);
        $this->setNumberOfBatches(0);
    }

    /**
     * @return string
     */
    public function getName() : string
    {
        return $this->name;
    }

    private function setName($name): void
    {
        $this->name = $name;
    }

    /**
     * @return int
     */
    public function getNumberOfBatches() : int
    {
        return $this->number_of_batches;
    }

    private function setNumberOfBatches($number_of_batches): void
    {
        $this->number_of_batches = $number_of_batches;
    }

    public function increaseBatches(int $value) : void {
        $this->number_of_batches += $value;
    }

    /**
     * @return array
     */
    public function getPokemons() : array
    {
        return $this->pokemons;
    }

    private function setPokemons($pokemons): void
    {
        $this->pokemons = $pokemons;
    }

    public function addPokemon(Pokemon $pokemon) : void {
        $this->pokemons[] = $pokemon;
    }

    public function hasPokemonDied() : bool {
        foreach ($this->getPokemons() as $pokemon) {
            if ($pokemon->getHealth() <= 0) {
                return true;
            }
        }
        return false;
    }

    public function removePokemons() : void {
        foreach ($this->getPokemons() as $index => $pokemon) {
            if ($pokemon->getHealth() <= 0) {
                array_splice($this->pokemons, $index, 1);
            }
        }
    }

    public function __toString()
    {
       return $this->getName() . ' ' . $this->getNumberOfBatches() . ' ' . count($this->getPokemons()) . PHP_EOL;
    }
}

$trainers = [];
while (true) {
    $line = readline();

    if ($line == 'Tournament'){
        break;
    }

    $parts = explode(' ', $line);
    $trainer_name = $parts[0];
    $pokemon_name = $parts[1];
    $pokemon_element = $parts[2];
    $pokemon_health = intval($parts[3]);

    $pokemon = new Pokemon($pokemon_name, $pokemon_element, $pokemon_health);
    $trainer = new Trainer($trainer_name, $pokemon);

    if (!key_exists($trainer_name, $trainers)) {
        $trainers[$trainer_name] = $trainer;
    } else {
        $trainers[$trainer_name]->addPokemon($pokemon);
    }
}

while (true) {
    $line = readline();

    if ($line == 'End') {
        break;
    }

    foreach ($trainers as $trainer) {
        foreach ($trainer->getPokemons() as $pokemon) {
            $element = $pokemon->getElement();

            if ($line == $element) {
                $trainer->increaseBatches(1);
                break;
            } else {
                $pokemon->decreaseHealth(10);
            }
        }

        if ($trainer->hasPokemonDied()) {
            $trainer->removePokemons();
        }
    }

}

usort($trainers, function ($trainer1, $trainer2) {
    return $trainer2->getNumberOfBatches() - $trainer1->getNumberOfBatches();
});

foreach ($trainers as $trainer) {
    echo $trainer;
}
?>