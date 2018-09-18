<?php
$firstNum = 100;
$secondNum = 20;
$thirdNum = 30;

$currentMax = $firstNum;
if($secondNum > $firstNum){
    $currentMax = $secondNum;
}

if($thirdNum > $currentMax){
    $currentMax = $thirdNum;
}

echo 'Max number between three number: '.$currentMax;

?>

