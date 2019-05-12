<?php
$radius = doubleval(readline());
$result = pi() * $radius * $radius;

$result = number_format($result, 12, '.', '');
echo $result;

?>