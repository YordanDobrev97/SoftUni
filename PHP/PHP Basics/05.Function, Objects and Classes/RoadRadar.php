<?php

$speed = 40;
$area  = 'city';

$max_limit_speed = getLimit($area);

isValidSpeed($speed, $max_limit_speed);

function isValidSpeed($speed, $max_speed){
    if($speed <= $max_speed){
        printMessage(true);
    }else{
        printMessage(false);
    }
}

function printMessage($normal_speed){
    if($normal_speed){
        echo 'The speed is normal';
    }else{
        echo 'The speed is not normal'; 
    }
}

function getLimit($area){
    
    switch ($area){
        case 'motorway':
            $speed = 130;
            break;
        case 'interstate':
            $speed = 90;
            break;
        case 'city':
            $speed = 50;
            break;
        case 'residential':
            $speed = 20;
            break;
        default:
            echo 'Not valid';
            $speed = 1000;
            break;
    }
    return $speed;
}

?>

