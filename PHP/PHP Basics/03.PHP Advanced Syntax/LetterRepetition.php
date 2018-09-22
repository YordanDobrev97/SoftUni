<?php

$charachters = "The quick brown fox jumps over the lazy dog";
$countSymbols = [];

for($i = 0; $i < strlen($charachters); $i++){
    $currentSymbol = $charachters[$i];
    if(!array_key_exists($charachters[$i], $countSymbols)){
        $countSymbols[$currentSymbol] = 0;
    }
    $countSymbols[$currentSymbol]++;
}

foreach($countSymbols as $key => $value){
    echo "$key -> $value"."<br>";
}

?>

