<?php
$phone_book = [];

while (true) {
    $line = readline();

    if ($line == 'END') {
        break;
    }

    $parts = explode(' ', $line);
    $command = $parts[0];
    $name = $parts[1];

    if ($command == 'A') {
        $number = $parts[2];
        $phone_book[$name] = $number;
    } else {
        if (!key_exists($name, $phone_book)) {
            echo "Contact $name does not exist.".PHP_EOL;
        } else {
            echo "$name -> $phone_book[$name]".PHP_EOL;
        }
    }
}
?>