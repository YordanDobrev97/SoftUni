<?php
$numbers = array_map('floatval', explode(' ', readline()));

foreach ($numbers as $number) {
    $rounding = round($number, 0, PHP_ROUND_HALF_UP);
    echo "$number => $rounding".PHP_EOL;
}

?>