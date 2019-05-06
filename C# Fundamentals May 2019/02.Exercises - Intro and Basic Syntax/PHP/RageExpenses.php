<?php
$lostGamesCount = intval(readline());
$headsetPrice = floatval(readline());
$mousePrice = floatval(readline());
$keyboardPrice = floatval(readline());
$displayPrice = floatval(readline());

$trashedHeadsetCount = 0;
$trashedMouseCount = 0;
$trashedKeyboard = 0;
$trashedDisplay = 0;

for ($i = 1; $i <= $lostGamesCount; $i++) {
    if ($i % 2 === 0) {
        $trashedHeadsetCount++;
    }

    if ($i % 3 === 0) {
        $trashedMouseCount++;
    }

    if ($i % 6 === 0) {
        $trashedKeyboard++;
    }

    if ($i % 12 === 0) {
        $trashedDisplay++;
    }
}

$totalCost = $trashedHeadsetCount * $headsetPrice +
    $trashedMouseCount * $mousePrice + $trashedKeyboard * $keyboardPrice
    + $trashedDisplay * $displayPrice;

$totalCost = number_format($totalCost, 2, '.', '');
echo "Rage expenses: $totalCost lv.";
?>