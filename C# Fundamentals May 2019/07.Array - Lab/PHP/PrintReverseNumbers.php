<?php
$size = intval(readline());

$numbers = [];
for ($i = 0; $i < $size; $i++) {
    $value = intval(readline());
    $numbers[] = $value;
}

$reverseNumbers = [];

for ($i = count($numbers) - 1; $i >= 0; $i--) {
    $reverseNumbers[] = $numbers[$i];
}

foreach ($reverseNumbers as $value) {
    echo "$value ";
}
?>
