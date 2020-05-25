<?php
$count_numbers = intval(readline());
$reversed_numbers = [];

for ($i = 0; $i < $count_numbers; $i++) {
    $number = intval(readline());
    array_unshift($reversed_numbers, $number);
}

echo join(' ', $reversed_numbers);
?>