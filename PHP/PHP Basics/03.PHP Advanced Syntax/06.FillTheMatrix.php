<?php
$input = explode(', ', readline());
$size = intval($input[0]);
$pattern = $input[1];

if ($pattern == 'A') {
    $matrix = fillPatternA($size, $matrix);
    printMatrix($matrix);
}else {
    $matrix = fillPatternB($size, $matrix);
    printMatrix($matrix);
}

function fillPatternA($size, $matrix) {
    $value = 1;
    $count_of_reaching = $size * $size;

    $row = 0;
    $col = 0;
    while ($value < $count_of_reaching) {
        while ($row < $size) {
            $matrix[$row][$col] = $value;
            $value++;
            $row++;
        }

        $col++;
        $row = 0;
    }
    return $matrix;
}

function fillPatternB($size, $matrix) {
    $value = 1;
    $count_of_reaching = $size * $size;

    $row = 0;
    $col = 0;
    while ($value < $count_of_reaching) {
        while ($row < $size) {
            $matrix[$row][$col] = $value;
            $value++;
            $row++;
        }

        if ($value >= $count_of_reaching) {
            break;
        }

        $col++;
        $row -= 1;

        while ($row >= 0) {
            $matrix[$row][$col] = $value;
            $value++;
            $row--;
        }

        $row += 1;
        $col++;
    }
    return $matrix;
}

function printMatrix($matrix) {
    foreach ($matrix as $array) {
       echo join (' ', $array).PHP_EOL;
    }
}