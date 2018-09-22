<?php
$array = explode(" ", "7 7 7 0 2 2 2 0 10 10 10");
$dictionary = [];

for($i = 0; $i < count($array); $i++){
    $element = $array[$i];
    
    if(!array_key_exists($element, $dictionary)){
        $dictionary[$element] = 1;
    }else{
        $dictionary[$element]++;
    }
}

$max_value = 0;
$key_of_max_value = null;
foreach($dictionary as $key => $value){
    if($max_value < $value){
        $max_value = $value;
        $key_of_max_value = $key;
    }
}
echo "Most Frequent number: $key_of_max_value count: $max_value";
?>

