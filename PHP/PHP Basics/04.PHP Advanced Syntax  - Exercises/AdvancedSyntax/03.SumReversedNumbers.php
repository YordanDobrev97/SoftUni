<?php
$elements = array_map('intval', explode(' ', readline()));

$sum = 0;
for($i = 0; $i < count($elements); $i++){
    $element = $elements[$i];
    $reversed = intval(strrev($element));
    $sum += $reversed;
}
echo $sum;
?>