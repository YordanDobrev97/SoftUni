<?php

$start = 100;
$end = 48;

$min = min($start, $end);
$max = max($start, $end);

for($i = $min; $i <= $max; $i++){
    echo $i."<br>";
}
?>

