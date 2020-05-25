<?php
$input = explode(', ', readline());
$row = intval($input[0]);
$col = intval($input[1]);

$matrix = read_matrix($row, $col);
$sum_of_matrix = get_sum($matrix);

echo $row.PHP_EOL;
echo $col.PHP_EOL;
echo $sum_of_matrix.PHP_EOL;

function read_matrix($row, $col) {
    $matrix = [];

    for ($rows = 0; $rows < $row; $rows++) {
        $values = array_map('intval', explode(', ', readline()));

        for ($cols = 0; $cols < $col; $cols++) {
            $value = $values[$cols];
            $matrix[$rows][$cols] = $value;
        }
    }

    return $matrix;
}

function get_sum($matrix) {
    $sum_of_matrix = 0;
    foreach($matrix as $current_row){
        foreach($current_row as $current_col){
            $sum_of_matrix += $current_col;
        }
    }
    return $sum_of_matrix;
}
?>