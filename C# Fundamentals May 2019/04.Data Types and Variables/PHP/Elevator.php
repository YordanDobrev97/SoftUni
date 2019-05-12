<?php
$numberPeople = intval(readline());
$capacity = intval(readline());

$result = ceil($numberPeople / $capacity);
echo $result;

?>
