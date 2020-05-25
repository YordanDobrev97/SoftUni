<?php
$n = intval(readline());
$k = intval(readline());

$arr = [1];

for($i = 1; $i< $n; $i++){
    $s = 0;
    
    $start = max(0, $i - $k);
    for($j = $start; $j < $i; $j++){
        $s += $arr[$j];
    }
    array_push($arr, $s);
}

foreach($arr as $value){
    echo "$value ";
}