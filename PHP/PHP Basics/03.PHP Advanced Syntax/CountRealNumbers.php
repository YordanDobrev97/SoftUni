<?php

$numbers = [8,2.5,2.5,8,2.5];

$countNumbers = [];


for ($i = 0; $i < count($numbers); $i++) {
    $currentEl = $numbers[$i] . "";
    if (!array_key_exists($currentEl, $countNumbers)) {
        $countNumbers[$currentEl] = 1;
    } else {
        $countNumbers[$currentEl]++;
    }
}

foreach($countNumbers as $key => $value){
    echo "$key => $value"."<br>";
}

?>

