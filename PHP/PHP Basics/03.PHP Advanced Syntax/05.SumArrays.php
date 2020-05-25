<?php
$first_array = explode(' ', readline());
$second_array = explode(' ', readline());

$first_array_length = count($first_array);
$second_array_length = count($second_array);

function dublicateItems($array, $size)  {
    $indx = 0;
    while (count($array) < $size) {
        $value = $array[$indx];
        array_push($array, $value);
        $indx++;

        if ($indx >= count($array)) {
            $indx = 0;
        }
    }
    return $array;
}

if ($first_array_length < $second_array_length) {
    $first_array = dublicateItems($first_array, $second_array_length);
} else if ($first_array_length > $second_array_length) {
    $second_array = dublicateItems($second_array, $first_array_length);
}

$result_array = [];

$max_length = max(count($first_array), count($second_array));
$index = 0;
while (true) {
    if ($index >= $max_length) {
        break;
    }
    $element_from_first = $first_array[$index];
    $element_from_second = $second_array[$index];
    $sum = $element_from_first + $element_from_second;
    array_push($result_array, $sum);
    $index++;
}

echo join(' ', $result_array);
?>