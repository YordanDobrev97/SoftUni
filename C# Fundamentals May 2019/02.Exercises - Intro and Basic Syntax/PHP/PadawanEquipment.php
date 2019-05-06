<?php
$amountMoney = floatval(readline());
$numberStudents = intval(readline());
$priceOfLightsabers = floatval(readline());
$priceOfRobes = floatval(readline());
$priceOfBelts = floatval(readline());

$discountStudents = ceil($numberStudents + ($numberStudents * 0.10));
$lightsabersPrice = $priceOfLightsabers * $discountStudents;
$robesPrice = $priceOfRobes * $numberStudents;
$discountBelts = ceil($numberStudents - $numberStudents / 6);
$beltsPrice = $priceOfBelts * $discountBelts;

$totalPrice = $lightsabersPrice + $robesPrice + $beltsPrice;

if ($totalPrice <= $amountMoney) {
    $totalPrice = number_format($totalPrice, 2, '.', '');
    echo "The money is enough - it would cost $totalPrice"."lv.";
} else {
    $needMoney = $totalPrice - $amountMoney;
    $needMoney = number_format($needMoney, 2, '.', '');
    echo "Ivan Cho will need $needMoney"."lv more.";
}

?>
