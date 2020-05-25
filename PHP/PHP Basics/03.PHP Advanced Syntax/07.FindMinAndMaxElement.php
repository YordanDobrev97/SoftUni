<?php
$input = explode(', ', readline());
$row = intval($input[0]);
$col = intval($input[1]);

$matrix = read_matrix($row, $col);
$min = find_min_element($matrix);
$max = find_max_element($matrix);

echo "Min: $min".PHP_EOL;
echo "Max: $max";

function read_matrix($row, $col) {
    $matrix = [];

    for ($rows = 0; $rows < $row; $rows++) {
        $values = explode(', ', readline());

        for ($cols = 0; $cols < $col; $cols++) {
            $value = $values[$cols];
            $matrix[$rows][$cols] = $value;
        }
    }

    return $matrix;
}

function find_min_element($matrix) {
    $min = PHP_INT_MAX;

    foreach ($matrix as $array) {
        foreach ($array as $value) {
            if ($value < $min) {
                $min = $value;
            }
        }
    }

    return $min;
}

function find_max_element($matrix) {
    $max = PHP_INT_MIN;

    foreach ($matrix as $array) {
        foreach ($array as $value) {
            if ($max < $value) {
                $max = $value;
            }
        }
    }

    return $max;
}

function printMatrix($matrix) {
    foreach ($matrix as $array) {
        echo join (' ', $array).PHP_EOL;
    }
}
?>