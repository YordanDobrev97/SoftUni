<?php
$number = intval(readline());

$sum = 0;
while ($number > 0) {
    $lastDigit = $number % 10;
    $sum += $lastDigit;

    $number/=10;
}

echo $sum.PHP_EOL;
?>
