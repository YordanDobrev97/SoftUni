<?php
$array = explode(' ', readline());
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
echo $key_of_max_value;
?>