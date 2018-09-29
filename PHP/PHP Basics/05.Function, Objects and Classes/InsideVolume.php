<?php

$input = "13.1, 50, 31.5, 50, 80, 50, -5, 18, 43";

$numbers = explode(", ", $input);

$length_Of_Arrray = count($numbers);

for($i = 0; $i < $length_Of_Arrray; $i+=3){
    $x = $numbers[$i];
    $y = $numbers[$i + 1];
    $z = $numbers[$i + 2];
    
    //echo 'X: $x  Y: $y  Z: $z';
    
    if(isVolume($x, $y,$z)){
        echo 'inside'."<br>";
    }else{
        echo 'outside'."<br>";
    }
}
function isVolume(int $x, int $y, int $z): bool{
    $x1 = 10;
    $x2 = 50;
    
    $y1 = 20;
    $y2 = 80;
    
    $z1 = 15;
    $z2 = 50;
    
    if($x >= $x1 && $x <= $x2){
        if($y >= $y1 && $y <= $y2){
            if($z >= $z1 && $z <= $z2){
                return true;
            }
        }
    }
    return false;
}

?>
