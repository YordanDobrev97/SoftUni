<?php
$firstArray = array_map('intval', explode(' ', readline()));
$secondArray = array_map('intval', explode(' ', readline()));

$index = 0;
$diffIndex = 0;
$sum = 0;
$isEqual = true;
$lengthArray = min(count($firstArray), count($secondArray));

while ($index < $lengthArray) {
    $firstValue = $firstArray[$index];
    $secondValue = $secondArray[$index];

    if ($firstValue !== $secondValue) {
        $diffIndex = $index;
        $isEqual = false;
        break;
    } else {
        $sum += $firstValue;
    }
    $index++;
}

if ($isEqual) {
    echo "Arrays are identical. Sum: $sum".PHP_EOL;
} else {
    echo "Arrays are not identical. Found difference at $diffIndex index.".PHP_EOL;
}
?>
