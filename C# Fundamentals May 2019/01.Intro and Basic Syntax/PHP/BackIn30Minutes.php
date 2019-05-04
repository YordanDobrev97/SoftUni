<?php
$hour = intval(readline());
$minutes = intval(readline());

$minutes += 30;

if ($minutes >=60) {
    $hour++;
    $minutes -=60;
}

if ($hour >=24) {
    $hour = 0;
}

$result = sprintf('%d:%02d', $hour, $minutes);
echo $result;
?>