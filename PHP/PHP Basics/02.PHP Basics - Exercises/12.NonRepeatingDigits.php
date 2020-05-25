<?php
$number = intval(readline());

//if number is less 100 not have generate the 3 digit number
if ($number < 100) {
    echo 'no';
} else {
    $values = [];
    for ($i = 100; $i <= $number; $i++) {
        if ($i < 1000) {
            $firstDigit = $i % 10;
            $secondDigit = floor($i % 100 / 10);
            $thirdDigit = floor($i % 1000 / 100);

            if ($firstDigit != $secondDigit && $firstDigit != $thirdDigit && $secondDigit != $thirdDigit) {
                array_push($values, $i);
            }
        }
    }

    echo join(', ', $values);
}
?>
