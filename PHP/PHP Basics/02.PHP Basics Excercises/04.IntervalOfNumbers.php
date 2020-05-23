<?php
$start = intval(readline());
$end = intval(readline());

$min = min($start, $end);
$max = max($start, $end);

for($i = $min; $i <= $max; $i++){
    echo $i.PHP_EOL;
}

?>

