<?php
$month = date('m', strtotime(readline()));

$totalDays =cal_days_in_month(CAL_GREGORIAN, $month, 2018);

for ($i = 1; $i <= $totalDays; $i++) {
    $currentDay = date('N', strtotime(2018 . '-' .$month . '-' .$i));
    if ($currentDay == 7) {
        echo $i .'rd '. $month . ', '. '2018'.PHP_EOL;
    }
}
?>