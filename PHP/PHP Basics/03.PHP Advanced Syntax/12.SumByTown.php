<?php
$line = readline();
$items = explode(', ', $line);
$dict = [];

for($i = 0; $i < count($items); $i+=2){
    $item = $items[$i];
    $nextItem = $items[$i + 1];
    if(!array_key_exists($item, $dict)){
        $dict[$item] = $nextItem;
    }else{
        $dict[$item] += $nextItem;
    }
}

foreach ($dict as $key => $value){
    echo "$key -> $value".PHP_EOL;
}
?>