<?php
$numberPeople = intval(readline());
$group = readline();
$day = readline();

$price = 0;

if ($group === "Students") {
    if ($day === "Friday") {
        $price = 8.45;
    } else if ($day === "Saturday") {
        $price = 9.80;
    } else if ($day === "Sunday") {
        $price = 10.46;
    }

} else if ($group === "Business") {
    if ($day === "Friday") {
        $price = 10.90;
    } else if ($day === "Saturday") {
        $price = 15.60;
    } else if ($day === "Sunday") {
        $price = 16;
    }
} else if ($group === "Regular") {
    if ($day === "Friday") {
        $price = 15;
    } else if ($day === "Saturday") {
        $price = 20;
    } else if ($day === "Sunday") {
        $price = 22.50;
    }
}

$price *= $numberPeople;

if ($numberPeople >= 30 && $group === "Students") {
    $price = $price - ($price * 0.15);
} else if ($numberPeople >= 100 && $group === "Business") {
    $price = $price - ($price * 0.1);
}  else if ($numberPeople >= 10 && $numberPeople <= 20 && $group === "Regular") {
    $price = $price - ($price * 0.05);
}

$price = number_format($price, 2, '.', '');
echo "Total price: $price";

?>
