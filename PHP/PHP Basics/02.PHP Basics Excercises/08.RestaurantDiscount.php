<?php
$sizeGroup = intval(readline());
$typePackage = readline();

if ($sizeGroup > 120) {
    echo 'We do not have an appropriate hall.';
} else {
    $priceHall = 0;
    $hall = '';

    if ($sizeGroup <= 50) {
        //small hall
        $hall = 'Small hall';
        $priceHall = 2250;
    } else if ($sizeGroup <= 100) {
        //Terrace
        $hall = 'Terrace';
        $priceHall = 5000;
    } else if ($sizeGroup <= 120) {
        //Great Hall
        $hall = 'Great Hall';
        $priceHall = 7500;
    }

    $pricePackage = 0;
    $discount = 0;

    if ($typePackage == 'Normal') {
        $pricePackage = 500;
        $discount = 0.05;
    } else if ($typePackage == 'Gold') {
        $pricePackage = 750;
        $discount = 0.10;
    } else if ($typePackage == 'Platinum') {
        $pricePackage = 1000;
        $discount = 0.15;
    }

    $totalPrice = $priceHall + $pricePackage;
    $resultDiscount = $totalPrice - ($totalPrice * $discount);
    $pricePerPerson = $resultDiscount / $sizeGroup;

    echo 'We can offer you the '.$hall.PHP_EOL;
    echo 'The price per person is '.number_format($pricePerPerson, 2).'$';
}
?>

