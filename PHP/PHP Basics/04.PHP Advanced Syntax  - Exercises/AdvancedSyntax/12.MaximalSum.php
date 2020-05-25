<?php
$input = explode(' ', readline());
$row = intval($input[0]);
$col = intval($input[1]);

$matrix = read_matrix($row, $col);

$max_sum = 0;
$row_position = 0;
$col_position = 0;

for ($rows = 0; $rows < $row - 2; $rows++) {
    for ($cols = 0; $cols < $col - 2; $cols++) {
        $sum = $matrix[$rows][$cols] + $matrix[$rows][$cols + 1] + $matrix[$rows][$cols + 2]
           + $matrix[$rows + 1][$cols] + $matrix[$rows + 1][$cols + 1] + $matrix[$rows + 1][$cols + 2]
            + $matrix[$rows + 2][$cols] + $matrix[$rows + 2][$cols + 1] + $matrix[$rows + 2][$cols + 2];

        if ($sum > $max_sum) {
            $max_sum = $sum;
            $row_position = $rows;
            $col_position = $cols;
        }
    }
}

echo 'Sum = '.$max_sum.PHP_EOL;
echo $matrix[$row_position][$col_position] . ' ' . $matrix[$row_position][$col_position + 1] . ' ' . $matrix[$row_position][$col_position + 2].PHP_EOL;
echo $matrix[$row_position + 1][$col_position] . ' ' . $matrix[$row_position + 1][$col_position + 1] . ' ' . $matrix[$row_position + 1][$col_position + 2].PHP_EOL;
echo $matrix[$row_position + 2][$col_position] . ' ' . $matrix[$row_position + 2][$col_position + 1] . ' ' . $matrix[$row_position + 2][$col_position + 2].PHP_EOL;

function read_matrix($row, $col) {
    $matrix = [];
    for ($i = 0; $i < $row; $i++) {
        $values = explode(' ', readline());
        for ($j = 0; $j < $col; $j++) {
            $matrix[$i][$j] = $values[$j];
        }
    }
    return $matrix;
}
?>