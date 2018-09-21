<?php

//4 2 8 6
//2 7 5 0
$array = [2,7,5,0];

for($i1 = 0; $i1 < count($array); $i1++){
    $currenItem = $array[$i1];
    for($i2 = $i1 + 1; $i2 < count($array); $i2++){
        $nextItem = $array[$i2];
        $sum = $currenItem + $nextItem;
        if(in_array($sum, $array)){
            echo "$currenItem + $nextItem == $sum"."<br>";
        }
    }
}

?>

