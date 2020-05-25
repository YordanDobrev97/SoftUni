<?php
$size = intval(readline());
$matrix = read_matrix($size, $size);

$length = count($matrix);
$leftSum = get_left_sum($matrix, $length);
$rightSum = get_right_sum($matrix, $length);

$difference = abs($leftSum - $rightSum);
echo $difference;

function read_matrix($row, $col) {
    $matrix = [];

    for ($rows = 0; $rows < $row; $rows++) {
        $values = explode(' ', readline());

        for ($cols = 0; $cols < $col; $cols++) {
            $value = $values[$cols];
            $matrix[$rows][$cols] = $value;
        }
    }

    return $matrix;
}

function get_left_sum($matrix, $length) {
    $leftSum = 0;

    for($row = 0; $row < $length; $row++){
        $element = $matrix[$row][$row];
        $leftSum += $element;
    }
    return $leftSum;
}

function get_right_sum($matrix, $length) {
    $row = 0;
    $rightSum = 0;
    for($i = $length - 1; $i >= 0; $i--){
        $element = $matrix[$row][$i];
        $rightSum +=$element;
        $row++;
    }

    return $rightSum;
}
?>