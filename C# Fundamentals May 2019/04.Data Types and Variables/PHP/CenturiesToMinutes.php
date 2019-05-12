<?php
$centuries = intval(readline());

$years = $centuries * 100;
$days = (int)($years * 365.2422);
$hours = $days * 24;
$minutes = $hours * 60;

echo "$centuries centuries = $years years = $days days = $hours hours = $minutes minutes";
?>