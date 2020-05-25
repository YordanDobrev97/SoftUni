<?php
$n = intval(readline());

$sum = 0;
$number = 1;
for($i = 1; $i <= $n; $i++){
    echo $number.PHP_EOL;
    $sum += $number;
    $number += 2;
}

echo "Sum: ".$sum;

?>

