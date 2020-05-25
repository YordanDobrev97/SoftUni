<?php
$products = [];

while (true) {
    $line = readline();

    if ($line == 'shopping time') {
        break;
    }

    $parts = explode(' ', $line);
    $product_name = $parts[1];
    $quantity = intval($parts[2]);

    if (!key_exists($product_name, $products)) {
        $products[$product_name] = $quantity;
    } else {
        $products[$product_name] += $quantity;
    }
}

while (true) {
    $line = readline();

    if ($line == 'exam time') {
        break;
    }

    $parts = explode(' ', $line);
    $product_name = $parts[1];
    $quantity = intval($parts[2]);

    if (!key_exists($product_name, $products)) {
        echo "$product_name doesn't exist".PHP_EOL;
    } else if ($products[$product_name] <= 0) {
        echo "$product_name out of stock".PHP_EOL;
    } else {
        $products[$product_name] -= $quantity;
    }
}

foreach ($products as $key => $value) {
    if ($value > 0) {
        echo $key . ' -> ' . $value.PHP_EOL;
    }
}
?>