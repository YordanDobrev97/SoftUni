<?php
$arr = array_map('intval',explode(' ', readline()));
$number_rotate = intval(readline());
$array_sum = [];

for($i = 0; $i < $number_rotate; $i++){
    $last_element = array_pop($arr);
    array_unshift($arr, $last_element);

    if(count($array_sum) == 0){
        for($j = 0; $j < count($arr); $j++){
            array_push($array_sum, $arr[$j]);
        }
    }else{
        for($j = 0; $j < count($arr); $j++){
            $array_sum[$j] += $arr[$j];
        }
    }
}

foreach($array_sum as $item){
    echo "$item ";
}
?>