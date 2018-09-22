<?php
$size = 4;
$pattern = "B";

$matrix = [[]];
$row = 0;
$col = 0;
$counter = 1;
$end = $size * $size;

if($pattern == "A"){
    processing_to_pattern_A($size, $row, $col, $counter, $end);
}else{
    processing_to_pattern_B($size, $row, $col, $counter, $end);
}

function print_matrix($matrix){
    foreach($matrix as $row){
        foreach($row as $col){
            echo $col."      ";
        }
        echo "<br>";
    }
}

function processing_to_pattern_A($size, $row,$col, $counter, $end){
    while ($counter <= $end){
        
        for($row = 0; $row < $size; $row++){
            $matrix[$row][$col] = $counter;
            $counter++;
        }
        $row = 0;
        $col++;
        /*
         1 5 9  13 
         2 6 10 14
         3 7 11 15
         4 8 12 16
         */
    }
    print_matrix($matrix);
}

function  processing_to_pattern_B($size, $row,$col, $counter, $end){
    while($counter <= $end){
        for($r = 0; $r< $size; $r++){
            $matrix[$r][$col] = $counter;
            $counter++;
            $row = $r;
        }
        $col++;
        
        for($i = 0; $i < $size; $i++){
            $matrix[$row][$col] = $counter;
            $row--;
            $counter++;
        }
        $col++;
        $row = 0;
        /*
         1 8 9
         2 7 10
         3 6 11
         4 5
         */
    }
    print_matrix($matrix);
}
?>

