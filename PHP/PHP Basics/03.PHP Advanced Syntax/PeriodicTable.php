<?php

$line = "Ge, Ch, O, Ne, Nb, Mo, Tc, O, Ne";
$elements = explode(", ", $line);

$dict = [];

for($i = 0; $i < count($elements); $i++){
    $element = $elements[$i];
    
    if(!array_key_exists($element, $dict)){
        $dict[$element] = 1;
    }else{
        $dict[$element]++;
    }
}

foreach ($dict as $key => $value){
    if($value == 1){
      echo "$key ";   
    }
}

?>

