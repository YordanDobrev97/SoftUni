<?php

$data = array('Pesho' => 12, 'Stamat' => 31, 'Ivan' => 48);

ksort($data);

foreach($data as $key => $value){
    if($value >= 30){
       echo $key." => ".$value."<br>";    
    }
}
?>

