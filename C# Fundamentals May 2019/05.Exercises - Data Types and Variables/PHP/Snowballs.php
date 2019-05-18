<?php
$numberSnowballs = intval(readline());

$biggestSnowballsValue = 0;
$snowball = 0;
$ballTime = 0;
$ballQuantity = 0;

for ($i = 0; $i < $numberSnowballs; $i++) {
    $snowballSnow = intval(readline());
    $snowballTime = intval(readline());
    $snowballQuantity = intval(readline());

    $currentSnowballValue = pow($snowballSnow / $snowballTime, $snowballQuantity);

    if ($biggestSnowballsValue <=$currentSnowballValue) {
        $biggestSnowballsValue = $currentSnowballValue;
        $snowball = $snowballSnow;
        $ballTime = $snowballTime;
        $ballQuantity = $snowballQuantity;
    }
}
echo "$snowball : $ballTime = $biggestSnowballsValue ($ballQuantity)".PHP_EOL;
?>
