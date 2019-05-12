<?php
$firstNumber = intval(readline());
$secondNumber = intval(readline());
$thirdNumber = intval(readline());
$fourNumber = intval(readline());

$sum = $firstNumber + $secondNumber;
$divider = floor($sum / $thirdNumber);
$multiplying = $divider * $fourNumber;

echo $multiplying
?>