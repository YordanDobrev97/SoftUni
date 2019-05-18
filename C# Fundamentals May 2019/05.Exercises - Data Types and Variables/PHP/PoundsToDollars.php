<?php
$pounds = floatval(readline());

$dollars = $pounds * 1.31;

$dollars = number_format($dollars, 3, '.', '');

echo $dollars.PHP_EOL;

?>