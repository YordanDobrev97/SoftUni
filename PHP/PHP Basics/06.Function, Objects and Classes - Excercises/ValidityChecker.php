<?php

$x1 = 3;
$y1 = 0;
$x2 = 0;
$y2 = 4;

function distance($x1, $y1, $x2, $y2){
    $dx = $x1 - $x2;
    $dy = $y1 - $y2;
    
    $sqr = sqrt($dx**2 + $dy ** 2);
    return $sqr;
}

if(is_integer(distance($x1, $y1, 0, 0))){
    echo "$x1, $y1 to {0, 0} is valid";
}else{
    echo "$x1, $y1 to {0, 0} is invalid"."<br>";
}

if(is_integer(distance($x2, $y2, 0, 0))){
    echo "$x2, $y2 to {0, 0} is valid"."<br>";
}else{
    echo "$x2, $y2 to {0, 0} is invalid"."<br>";
}

if(is_integer(distance($x2, $y1, $x2, $y2))){
    echo "$x1, $y1 to $x2  $y2 is valid"."<br>";
}else{
    echo "$x1, $y1 to $x2  $y2 is invalid"."<br>";
}