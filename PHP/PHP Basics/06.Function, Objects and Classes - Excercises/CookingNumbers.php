<?php

function operations(){
    $number = 9;
$operations = ['dice', 'spice', 'chop', 'bake', 'fillet'];

foreach ($operations as $value){
    switch ($value){
        case 'chop':
            $number /=2;
            break;
        case 'dice':
            $number = sqrt($number);
            break;
        case 'spice':
            $number +=1;
            break;
        case 'bake':
            $number *=3;
            break;
        case 'fillet':
            $number = $number - ($number * 0.20);
            break;
    }
    echo $number."<br>";
}
}

