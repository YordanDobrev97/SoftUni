<?php
$startNumber = intval(readline());
$endNumber = intval(readline());

$sum = 0;

for ($i = $startNumber; $i <= $endNumber; $i++) {
    $sum += $i;
    echo "$i ";
}

echo PHP_EOL;
echo "Sum: $sum";
?>