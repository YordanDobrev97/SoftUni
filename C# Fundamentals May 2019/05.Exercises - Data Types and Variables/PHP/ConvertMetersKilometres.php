<?php
$meters = intval(readline());

$killometers = $meters * 0.001;
$killometers = number_format($killometers, 2, '.', '');

echo $killometers.PHP_EOL;

?>
