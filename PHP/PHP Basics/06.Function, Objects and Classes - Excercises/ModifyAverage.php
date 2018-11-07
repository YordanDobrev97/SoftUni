<?php
    $number = '101';   
    
    while(true){
        $sum = averageDigits($number);
        $average = $sum / strlen($number);
        if($average > 5){
            break;
        }
        $number = $number."9";
    }
    
    function averageDigits($num){
        $sum = 0;
        $parseNum = intval($num);
        while($parseNum > 0){
            $lastDigit = $parseNum % 10;
            $sum +=$lastDigit;
            $parseNum/=10;
        }
        return $sum;
    }
    echo $number;

