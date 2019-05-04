<?php

$n = intval(readline());
$range = floatval(readline());

$last = floatval(readline());
for ($i = 0; $i < $n - 1; $i++) {
    $number = floatval(readline());
    $price = ($number - $last) / $last;
    $isSignificantDifference = abs($price) >= $range;

    $message = "";
    if ($price == 0) {
        $message = "NO CHANGE: " . $number;
    } else if (!$isSignificantDifference) {
        $message = sprintf("MINOR CHANGE: %f to %f (%.2f%%)", $last, $number, $price * 100);
    } else if ($isSignificantDifference && ($price > 0)) {
        $message = sprintf("PRICE UP: %f to %f (%.2f%%)", $last, $number, $price * 100);
    } else if ($isSignificantDifference && ($price < 0))
        $message = sprintf("PRICE DOWN: %f to %f (%.2f%%)", $last, $number, $price * 100);
    echo $message . PHP_EOL;
    $last = $number;
}


?>
