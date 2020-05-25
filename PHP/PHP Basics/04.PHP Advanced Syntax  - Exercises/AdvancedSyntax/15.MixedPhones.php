<?php
$phone_book = [];

while (true) {
    $line = readline();

    if ($line == 'Over') {
        break;
    }

    $parts = explode(' : ', $line);
    $name = $parts[0];
    $phone_number = $parts[1];

    if (is_numeric($parts[0])) {
        $name = $parts[1];
        $phone_number = $parts[0];
    }

    $phone_book[$name] = $phone_number;
}

$names = array_keys($phone_book);
sort($names);

foreach ($names as $key) {
    echo $key .' -> '.$phone_book[$key].PHP_EOL;
}
?>