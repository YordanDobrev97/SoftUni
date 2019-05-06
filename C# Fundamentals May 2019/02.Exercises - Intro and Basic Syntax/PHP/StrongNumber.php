<?php
$number = intval(readline());
$numValue = $number;
$sum = 0;

while ($numValue > 0) {
    $lastDigit = $numValue % 10;

    $currentFactorial = 1;

    for ($i = 1; $i <= $lastDigit; $i++) {
        $currentFactorial *= $i;
    }

    $sum += $currentFactorial;
    $numValue /= 10;
    $numValue = intval($numValue);
}

if ($sum === $number) {
    echo "yes";
} else {
    echo "no";
}

?>