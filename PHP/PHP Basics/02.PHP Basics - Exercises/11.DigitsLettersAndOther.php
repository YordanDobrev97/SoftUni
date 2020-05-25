<?php
$input = readline();

$numbers = [];
$alphabets = [];
$junks = [];

for ($i = 0; $i < strlen($input); $i++) {
    if (is_numeric($input[$i])) {
        array_push($numbers, $input[$i]);
    } else if (ctype_alnum($input[$i])) {
        array_push($alphabets, $input[$i]);
    } else {
        array_push($junks, $input[$i]);
    }
}

echo join('', $numbers).PHP_EOL;
echo join('', $alphabets).PHP_EOL;
echo join('', $junks).PHP_EOL;
?>
