<?php

$line = "-1 hi ho w";
$elements = explode(" ", $line);

// 5
// 5 / 2 = 2
$length = count($elements)/2;
$tota_length = count($elements);
for($i = 0; $i < $length; $i++){
    $current_element = $elements[$i];
    $currentEndElement = $elements[$tota_length - 1 - $i];
    
   $temp = $elements[$i];
   $elements[$i] = $elements[$tota_length - 1 - $i];
   $elements[$tota_length - 1 - $i] = $temp;
}
foreach($elements as $element){
    echo "$element ";
}

?>

