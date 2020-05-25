<?php
$input = readline();
$countSymbols = [];

for($i = 0; $i < strlen($input); $i++){
    $currentSymbol = $input[$i];
    if(!array_key_exists($input[$i], $countSymbols)){
        $countSymbols[$currentSymbol] = 0;
    }
    $countSymbols[$currentSymbol]++;
}

foreach($countSymbols as $key => $value){
    echo "$key -> $value".PHP_EOL;
}
?>