<?php
$number = (int)readline();

for ($i = 1; $i <= $number; $i++) {
    $sumDigit = 0;
    $tempNumber = $i;

    while ($tempNumber > 0) {
        $digit = $tempNumber % 10;
        $sumDigit += $digit;
        $tempNumber /= 10;
    }

    $specialValue = "False";
    if ($sumDigit == 5 || $sumDigit == 7 || $sumDigit == 11) {
        $specialValue = "True";
    }
    echo $i." -> ".$specialValue.PHP_EOL;
}

?>
