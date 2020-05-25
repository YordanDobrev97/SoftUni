<?php
$numbers = array_map('intval', explode(' ', readline()));

if (count($numbers) == 1) {
    echo $numbers[0];
} else {
    $index = 0;
    while (count($numbers) > 1) {
        $first_value = $numbers[$index];
        $next_value = $numbers[$index + 1];
        $sum = $first_value + $next_value;
        $numbers[$index] = $sum;
        $index++;

        if ($index == count($numbers) - 1) {
            array_splice($numbers, count($numbers) - 1, 1);
            $index = 0;
        }
    }

    echo $numbers[0];
}
?>