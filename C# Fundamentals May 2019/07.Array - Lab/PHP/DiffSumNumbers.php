<?php
$numbers = array_map('intval', explode(' ', readline()));

$sumEvenNumbers = 0;
$sumOddNumbers = 0;

foreach ($numbers as $number) {
    if ($number % 2 === 0) {
        $sumEvenNumbers += $number;
    } else {
        $sumOddNumbers += $number;
    }
}

$diff = $sumEvenNumbers - $sumOddNumbers;
echo $diff.PHP_EOL;

?>
