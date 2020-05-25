<?php
$firstNum = floatval(readline());
$secondNum = floatval(readline());

$sum = $firstNum + $secondNum;
$round = number_format($sum, 2, '.', '');
echo '$firstNumber + $secondNumber = '.$firstNum." + ".$secondNum." = ".$round;
?>

