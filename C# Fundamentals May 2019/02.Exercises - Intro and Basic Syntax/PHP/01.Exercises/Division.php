<?php
$number = intval(readline());

$result = "Not divisible";
if ($number % 2 === 0) {
    $result = "The number is divisible by 2".PHP_EOL;
}

if ($number % 3 === 0) {
    $result = "The number is divisible by 3".PHP_EOL;
}

if ($number % 6 === 0) {
    $result = "The number is divisible by 6".PHP_EOL;
}

if ($number % 7 === 0) {
    $result = "The number is divisible by 7".PHP_EOL;
}

if ($number % 10 === 0) {
    $result = "The number is divisible by 10".PHP_EOL;
}

echo $result;
?>
