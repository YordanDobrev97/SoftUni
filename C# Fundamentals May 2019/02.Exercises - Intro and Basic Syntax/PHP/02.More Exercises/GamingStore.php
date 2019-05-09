<?php
$balance = doubleval(readline());

$totalPrice = 0;
while (true){
    $input = readline();

    if ($input === "Game Time") {
        break;
    }
    $gamePrice = 0;

    if ($input === "OutFall 4") {
        $gamePrice = 39.99;
    } else if ($input === "CS: OG") {
        $gamePrice = 15.99;
    } else if ($input === "Zplinter Zell") {
        $gamePrice = 19.99;
    } else if ($input === "Honored 2") {
        $gamePrice = 59.99;
    } else if ($input === "RoverWatch") {
        $gamePrice = 29.99;
    } else if ($input === "RoverWatch Origins Edition") {
        $gamePrice = 39.99;
    } else {
        echo "Not Found".PHP_EOL;
        continue;
    }

    if ($gamePrice > $balance) {
        echo "Too Expensive".PHP_EOL;
        continue;
    }

    $balance -= $gamePrice;
    $totalPrice += $gamePrice;

    echo "Bought $input".PHP_EOL;

    if ($balance === 0) {
        echo "Out of money!".PHP_EOL;
    }
}

$totalPrice = number_format($totalPrice, 2, '.', '');

echo "Total spent: $$totalPrice. Remaining: $$balance";

?>
