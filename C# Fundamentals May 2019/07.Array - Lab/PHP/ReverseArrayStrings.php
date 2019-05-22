<?php
$array = explode(' ', readline());

$reverse = [];
$lastIndex = count($array) - 1;

for ($i = $lastIndex; $i >= 0; $i--) {
    $reverse[] = $array[$i];
}

$result = implode(' ', $reverse);
echo "$result".PHP_EOL;

?>
