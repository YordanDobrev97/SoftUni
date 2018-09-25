<?php

$matrix = [
  
  [10, 11, 12, 13],
  [14, 15, 16, 17]
];

$length_of_row = count($matrix);
$length_of_col = count($matrix[0]) - 1;

$max_sum = 0;

$array_with_max_element_in_matrix = [];
for($i = 0; $i < $length_of_row - 1; $i++){
    for($j = 0; $j < $length_of_col; $j++){
         $first_row_element = $matrix[$i][$j];
         $second_row_element = $matrix[$i + 1][$j];
         
         $first_col_element = $matrix[$i][$j + 1];
         $second_col_element = $matrix[$i + 1][$j + 1];
         
         $sum = $first_row_element + $second_row_element + $first_col_element
                  + $second_col_element;
         
        if($sum >=$max_sum){
            $max_sum = $sum;
            $array_with_max_element_in_matrix[0] = $first_row_element;
            $array_with_max_element_in_matrix[1] = $first_col_element;
            $array_with_max_element_in_matrix[2] = $second_row_element;
            $array_with_max_element_in_matrix[3] = $second_col_element;
            
            $sum = 0;
        }
    }
}
echo "Max Sum: $max_sum"."<br>";

echo $array_with_max_element_in_matrix[0]." -> ".$array_with_max_element_in_matrix[1]."<br>";
echo $array_with_max_element_in_matrix[2]." -> ".$array_with_max_element_in_matrix[3]."<br>"
?>

