<?php
$line = readline();
$array = explode(' ', $line);

$min_element = min($array);
$index_of_min_element = array_search($min_element, $array);
$start_index = $index_of_min_element;
$length = count($array) - 1;

$has_sequence = false;
while($index_of_min_element < $length){
    $current = $array[$index_of_min_element];
    $next = $array[$index_of_min_element + 1];
    
    if($current < $next){
        $has_sequence = true;
    }else{
        break;
    }
    $index_of_min_element++;
}

while($start_index <= $index_of_min_element){
    $element = $array[$start_index];
    echo "$element" . ' ';
    $start_index++;
}
?>