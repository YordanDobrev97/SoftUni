<?php

$matrix = [
    [7, 1, 3, 3, 2, 1],
    [1, 3, 9, 8, -5, 6],
    [4, 6, 7, 9, 1, 1]
];


$min = find_min_element_at_matrix($matrix);
$max = find_max_element_at_matrix($matrix);
echo "Min element at matrix: $min"."<br>";
echo "Max element at matrix: $max"."<br>";


function find_min_element_at_matrix($matrix){
    $min = PHP_INT_MAX;

    foreach ($matrix as $row){
        foreach($row as $col){
            if($min > $col){
                $min = $col;
            }
        }
    }
    return $min;
    
}

function find_max_element_at_matrix($matrix){
    $max = PHP_INT_MIN;
    
    foreach($matrix as $row){
        foreach($row as $col){
            if($max < $col){
                $max = $col;
            }
        }
    }
    return $max;
}
?>

