<?php
$numbers = array_map('intval', explode(' ', readline()));

$sumEvenNumbers = 0;

foreach ($numbers as $number) {
    if ($number % 2 === 0) {
        $sumEvenNumbers += $number;
    }
}

echo "$sumEvenNumbers".PHP_EOL;

?>
