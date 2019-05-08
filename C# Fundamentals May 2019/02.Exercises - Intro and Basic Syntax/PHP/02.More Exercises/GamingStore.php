<?php
$balance = doubleval(readline());
$saveBalance = $balance;

$totalPrice = 0;
while (true){
    $input = readline();

    if ($input === "Game Time") {
        break;
    }

    $game = $input;
    $gamePrice = 0;

    if ($game === "OutFall 4") {
        $totalPrice += 39.99;
        $gamePrice = 39.99;
    } else if ($game === "CS:OG") {
        $totalPrice += 15.99;
        $gamePrice = 15.99;
    } else if ($game === "Zplinter Zell") {
        $totalPrice += 19.99;
        $gamePrice = 19.99;
    } else if ($game === "Honored 2") {
        $totalPrice += 59.99;
        $gamePrice = 59.99;
    } else if ($game === "RoverWatch") {
        $totalPrice += 29.99;
        $gamePrice = 29.99;
    } else if ($game === "RoverWatch Origins Edition") {
        $totalPrice += 39.99;
        $gamePrice = 39.99;
    } else {
        echo "Not Found".PHP_EOL;
        continue;
    }

    if ($gamePrice <= $balance) {
        echo "Bought $game".PHP_EOL;
        $balance -= $gamePrice;
    } else {
        echo "Too Expensive".PHP_EOL;
    }

    if ($balance === 0) {
        echo "Out of money!";
        break;
    }
}
$saveBalance -= $totalPrice;

if ($saveBalance <= 0) {
    echo "Out of money!";
} else {
    $totalPrice = number_format($totalPrice, 2, '.', '');
    $saveBalance = number_format($saveBalance, 2, '.','');

    echo "Total spent: $$totalPrice. Remaining: $$saveBalance";
}
?>
