<?php
$number = 15;

for($i = 1; $i <= $number; $i++){
    $sumDigit = 0;
    $digit = $i;
    
    while ($digit != 0){
        $sumDigit +=$digit % 10;
        $digit/=10;
    }
    
    if($sumDigit == 5 || $sumDigit == 7 || $sumDigit == 11){
        echo 'True '.$i."<br>";
    }else{
        echo 'False '.$i."<br>";
    }
}

?>

