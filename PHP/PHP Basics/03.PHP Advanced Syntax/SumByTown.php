<?php

$line = "Plovdiv, 40, Pernik, 20, Vidin, 8, Sliven, 44, Plovdiv, 1, Vidin, 7, Chirpan, 0";
$items = explode(", ", $line);

$dict = [];

for($i = 0; $i < count($items); $i+=2){
    $item = $items[$i];
    $nextItem = $items[$i + 1];
    if(!array_key_exists($item, $dict)){
        $dict[$item] = $nextItem;
    }else{
        $dict[$item] += $nextItem;
    }
}

foreach ($dict as $key => $value){
    echo "$key -> $value"."<br>";
}
?>

