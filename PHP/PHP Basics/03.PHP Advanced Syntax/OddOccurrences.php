<?php

$line = "a a A SQL xx a xx a A a XX c";
$line = strtolower($line);
$elements = explode(" ", $line);

$oddOccurrences = [];

for($i = 0; $i < count($elements); $i++){
    $currentElement = $elements[$i];
    
    if(!array_key_exists($currentElement, $oddOccurrences)){
        $oddOccurrences[$currentElement] = 0;
    }
    $oddOccurrences[$currentElement]++;
}

foreach ($oddOccurrences as $key => $value){
    if($value % 2 == 1){
        echo "$key ";
    }
}

?>

