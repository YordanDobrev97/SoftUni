<?php
$line = readline();
$elements = array_map('intval', explode(' ', $line));

$total_counter = 1;
$current_counter = 1;
$index = 0;
for($i = 0; $i < count($elements) - 1; $i++){
    $current = $elements[$i];
    $next = $elements[$i + 1];
    
    if($current === $next){
        $current_counter++;
    }else{
        if($current_counter > $total_counter){
            $total_counter = $current_counter;
            $index = $i;
        }
        $current_counter = 1;
    }
}
if($current_counter > $total_counter){
    $total_counter = $current_counter;
}

for ($i = 0; $i < $total_counter; $i++) {
    echo $elements[$index] . ' ';
}
?>