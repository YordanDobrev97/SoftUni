<?php
$input = explode(', ', readline());
$row = intval($input[0]);
$col = intval($input[1]);

$matrix = read_matrix($row, $col);

$length_of_row = count($matrix);
$length_of_col = count($matrix[0]) - 1;

$max_sum = 0;

$array_max_elements = [];
for($i = 0; $i < $length_of_row - 1; $i++){
    for($j = 0; $j < $length_of_col; $j++){
         $first_row_element = $matrix[$i][$j];
         $second_row_element = $matrix[$i + 1][$j];
         
         $first_col_element = $matrix[$i][$j + 1];
         $second_col_element = $matrix[$i + 1][$j + 1];
         
         $sum = $first_row_element + $second_row_element + $first_col_element
                  + $second_col_element;
         
        if($sum >= $max_sum){
            $max_sum = $sum;
            $array_max_elements[0] = $first_row_element;
            $array_max_elements[1] = $first_col_element;
            $array_max_elements[2] = $second_row_element;
            $array_max_elements[3] = $second_col_element;
            
            $sum = 0;
        }
    }
}

echo $array_max_elements[0]." ".$array_max_elements[1].PHP_EOL;
echo $array_max_elements[2]." ".$array_max_elements[3].PHP_EOL;
echo $max_sum;

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
?>