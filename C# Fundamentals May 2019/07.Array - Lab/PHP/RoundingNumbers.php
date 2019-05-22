<?php
$numbers = array_map('floatval', explode(' ', readline()));

foreach ($numbers as $number) {
    $rounding = round($number, 0, PHP_ROUND_HALF_UP);
    $resultNumber = number_format($number, 2, '.', '');
    echo "$resultNumber => $rounding".PHP_EOL;
}


?>