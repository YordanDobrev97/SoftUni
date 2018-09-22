<?php

$line_numbers = "12 12 12";
/*
 123
 321
 */
$elements = explode(" ", $line_numbers);

$sum = 0;
for($i = 0; $i < count($elements); $i++){
    $element = $elements[$i];
    $reversed = intval(strrev($element));
    $sum += $reversed;
}
echo "Sum: $sum";
?>

