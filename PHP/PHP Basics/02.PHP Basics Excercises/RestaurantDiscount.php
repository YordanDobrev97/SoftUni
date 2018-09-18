<?php
//90
//Platinum
$sizeGroup = 90;
$typePackage = "Platinum";

$price = 0;
$hall = "";
if($sizeGroup <= 50){
    $price = 2500;
    $hall = "Small Hall";
}else if($sizeGroup <= 100){
    $price = 5000;
    $hall = "Terrace";
}else if($sizeGroup <= 120){
    $price = 7500;
    $hall = "Great Hall";
}

$discount = 0;
$discountPrice = 0;
switch ($typePackage){
    case "Normal":
        $discount = 0.5;
        $discountPrice = 500;
        break;
    case "Gold":
        $discount = 0.10;
        $discountPrice = 750;
        break;
    case "Platinum":
        $discount = 0.15;
        $discountPrice = 1000;
        break;
}
$totalPrice = $price + $discountPrice;
$totalDiscount = $totalPrice - ($totalPrice * $discount);
$pricePerPerson = $totalDiscount / $sizeGroup;

//We can offer you the Small Hall
echo "We can offer you the $hall"."<br>";
//The price per person is 146.25$
echo "The price per person is ".round($pricePerPerson, 2)."<br>";

?>

