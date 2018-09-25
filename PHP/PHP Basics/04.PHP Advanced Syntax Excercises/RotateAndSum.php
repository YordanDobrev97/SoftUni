<?php

$line = "1 2 3 4 5";
$arr = array_map('intval',explode(" ", $line));
$number_rotate = 3;

$array_sum = [];

echo "Rotate:"."<br>";
for($i = 0; $i < $number_rotate; $i++){
    $last_element = array_pop($arr);
    array_unshift($arr, $last_element);
    
    foreach($arr as $val){
        echo "$val ";
    }
    echo "<br>";
    if(count($array_sum) == 0){
        //fill array
        for($j = 0; $j < count($arr); $j++){
            array_push($array_sum, $arr[$j]);
        }
    }else{
        for($j = 0; $j < count($arr); $j++){
            $array_sum[$j] += $arr[$j];
        }
    }
}
echo "<br>Sum from rotate:"."<br>";
foreach($array_sum as $item){
        echo "$item ";
}
?>

