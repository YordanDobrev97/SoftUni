<?php
$array = array_map('intval', explode(' ', readline()));

$has_sum = false;
for($i1 = 0; $i1 < count($array); $i1++){
    $current_item = $array[$i1];
    for($i2 = $i1 + 1; $i2 < count($array); $i2++){
        $next_item = $array[$i2];
        $sum = $current_item + $next_item;
        if(in_array($sum, $array)){
            $has_sum = true;
            echo $current_item. ' + '.$next_item. ' == '.$sum.PHP_EOL;
        }
    }
}

if (!$has_sum) {
    echo 'No';
}
?>