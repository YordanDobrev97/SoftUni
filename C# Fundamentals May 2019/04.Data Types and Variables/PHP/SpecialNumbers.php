<?php
$number = intval(readline());

for ($i = 1; $i <= $number; $i++) {
    $digits = $i;
    $sum = 0;
    while ($digits > 0) {
        $digit = $digits % 10;
        $sum += $digit;

        $digits/=10;
    }

    if ($sum === 5 || $sum === 7 || $sum === 11) {
        echo "$i -> True".PHP_EOL;
    } else {
        echo "$i -> False".PHP_EOL;
    }
}
?>
