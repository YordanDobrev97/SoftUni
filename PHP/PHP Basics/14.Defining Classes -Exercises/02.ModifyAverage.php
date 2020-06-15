<?php
$number = readline();
$result = modify_average($number);
echo $result;

function modify_average($number) {
    while (true) {
        $sum = sum_digits($number);
        $average_digits = $sum / strlen($number);

        if ($average_digits > 5) {
            break;
        }

        $number .= 9;
    }

    return $number;
}

function sum_digits($number) {
    $sum = 0;
    for ($i = 0; $i < strlen($number); $i++) {
        if ($number[$i] == '.') {
            continue;
        }
        $sum += $number[$i];
    }
    return $sum;
}

?>