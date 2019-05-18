<?php
$pokePower = intval(readline());
$distance = intval(readline());
$exhaustionFactorY = intval(readline());

$originalValue = $pokePower;
$target = 0;
$half = (int)($pokePower * 0.50);

while ($distance <= $pokePower) {
    $pokePower -= $distance;
    $target++;

    if ($pokePower === $half) {
        $pokePower /= (int)$exhaustionFactorY;
        $pokePower = (int)$pokePower;
    }
}
echo "$pokePower".PHP_EOL;
echo "$target".PHP_EOL;

?>
