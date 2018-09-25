<?php

//       0 1 2 3 4 5 6
$line = "7 3 2 3 5 2 2 4";
$array = explode(" ", $line);

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
echo "Start index $start_index. End Index: $index_of_min_element"."<br>";

echo "Max Sequence of Increasing Elements:"."<br>";

while($start_index <= $index_of_min_element){
    $element = $array[$start_index];
    echo "$element"."<br>";
    $start_index++;
}
?>

