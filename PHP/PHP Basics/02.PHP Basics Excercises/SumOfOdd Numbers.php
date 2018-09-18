<?php

$n = 3;

$sum = 0;
for($i = 1; $i <= $n; $i++){
    $num = $i + 2;
    echo $num."<br>";
    $sum += $num;
}

echo "Sum: $sum";

?>

