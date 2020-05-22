<?php
$firstNumber = (int)readline();
$secondNumber = (int)readline();
$thirdNumber = (int)readline();

$currentMax = max($firstNumber, $secondNumber);
$finallyMax = max($currentMax, $thirdNumber);

echo $finallyMax;
?>
