<?php
$line = readline();
$elements = explode(' ', $line);

$length = count($elements)/2;
$total_length = count($elements);
for($i = 0; $i < $length; $i++) {
    $current_element = $elements[$i];
    $currentEndElement = $elements[$total_length - 1 - $i];
    
    $temp = $elements[$i];
    $elements[$i] = $elements[$total_length - 1 - $i];
    $elements[$total_length - 1 - $i] = $temp;
}

foreach($elements as $element){
    echo "$element ";
}
?>