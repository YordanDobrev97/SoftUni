<?php

while (true) {
    $number = intval(readline());

    if ($number % 2 === 0) {
        $num = abs($number);
        echo "The number is: $num";
        break;
    }
    echo "Please write an even number.\n";
}
?>
