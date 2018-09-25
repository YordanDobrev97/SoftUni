<?php

$matrix = [
    [7, 1, 3, 3, 2, 1],
    [1, 3, 9, 8, 5, 6],
    [4, 6, 7, 9, 1, 0]
];

$sum_of_matrix = 0;

foreach($matrix as $row){
    foreach($row as $col){
       $sum_of_matrix += $col;
    }
}

echo "sum of the matrix: $sum_of_matrix";
?>

