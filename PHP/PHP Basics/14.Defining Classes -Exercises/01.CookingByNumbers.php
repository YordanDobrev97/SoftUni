<?php

function mutation_of_number(float $number, array $commands) : void
{
    $operations = [
        'chop' => function (float $number) : float {
             return $number / 2;
        },
        'dice' => function (float $number) : float {
            return sqrt($number);
        },
        'spice' => function (float $number) : float {
            return $number + 1;
        },
        'bake' => function (float $number) : float {
            return $number * 3;
        },
        'fillet' => function (float $number) : float {
            return $number - ($number * 0.20);
        }
    ];

    foreach ($commands as $command) {
        if (key_exists($command, $operations)) {
            $number = $operations[$command]($number);
            echo $number.PHP_EOL;
        }
    }
}

$number = floatval(readline());
$commands = explode(', ', readline());

mutation_of_number($number, $commands);
?>