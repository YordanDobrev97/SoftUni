<?php
$numbers = array_map('intval', explode(' ', readline()));

$length = count($numbers) - 1;

while ($length > 0) {
    for ($i = 0; $i < $length; $i++) {
        $currentElement = $numbers[$i];
        $nextElement = $numbers[$i + 1];

        $sum = $currentElement + $nextElement;
        $numbers[$i] = $sum;
    }
    $length--;
}

echo $numbers[0];
?>
