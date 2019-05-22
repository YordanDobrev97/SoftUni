<?php
$days = ['Monday', 'Tuesday', 'Wednesday',
    'Thursday', 'Friday', 'Saturday', 'Sunday'];

$day = intval(readline());

if ($day >= 1 && $day <= 7) {
    echo $days[$day - 1];
} else {
    echo 'Invalid Day!';
}

?>
