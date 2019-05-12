<?php
$number = intval(readline());
$start = 97;
$end = $start + $number;

for ($first = $start; $first < $end; $first++) {
    for ($second = $start; $second < $end; $second++) {
        for ($third = $start; $third < $end; $third++) {
            $result = chr($first).chr($second).chr($third);
            echo "$result".PHP_EOL;
        }
    }
}
?>
