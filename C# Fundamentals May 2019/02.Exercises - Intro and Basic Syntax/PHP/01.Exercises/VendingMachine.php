<?php
$sumCoins = 0.0;

while (true) {
    $coin = readline();

    if ($coin === "Start") {
        break;
    }

    $coinNumber = floatval($coin);

    switch ($coinNumber) {
        case 0.1:
        case 0.2:
        case 0.5:
        case 1:
        case 2:
            $sumCoins += $coinNumber;
            break;
        default:
            echo "Cannot accept $coin".PHP_EOL;
            break;
    }
}
$priceProduct = 0;
while (true) {
    $product = readline();

    if ($product === "End") {
        break;
    }

    $validProduct = true;
    switch ($product) {
        case "Nuts":
            $priceProduct = 2.0;
            $validProduct = true;
            break;
        case "Water":
            $priceProduct = 0.7;
            $validProduct = true;
            break;
        case "Crisps":
            $priceProduct = 1.5;
            $validProduct = true;
            break;
        case "Soda":
            $priceProduct = 0.8;
            $validProduct = true;
            break;
        case "Coke":
            $validProduct = true;
            $priceProduct = 1.0;
            break;
        default:
            echo "Invalid product".PHP_EOL;
            $validProduct = false;
            break;
    }

    if ($validProduct) {
        if ($priceProduct <= $sumCoins) {
            $toLower = strtolower($product);
            echo "Purchased $toLower".PHP_EOL;
            $sumCoins -= $priceProduct;
        } else {
            echo "Sorry, not enough money".PHP_EOL;
        }
    }
}
$result = number_format($sumCoins, 2, '.', '');
echo "Change: $result";
?>
