<?php
$n = 8;
$k = 2;

$arr = [1];

for($i = 1; $i< $n; $i++){
    $s = 0;
    
    $start = max(0, $i - $k);
    // 1 - 3 = 0
    for($j = $start; $j < $i; $j++){
        $s += $arr[$j];
    }
    array_push($arr, $s);
}

foreach($arr as $value){
    echo "$value ";
}

