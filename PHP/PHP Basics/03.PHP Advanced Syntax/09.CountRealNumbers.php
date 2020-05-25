<?php
$numbers = array_map('floatval', explode(' ', readline()));
$countNumbers = [];

for ($i = 0; $i < count($numbers); $i++) {
    $currentEl = $numbers[$i] . "";
    if (!array_key_exists($currentEl, $countNumbers)) {
        $countNumbers[$currentEl] = 1;
    } else {
        $countNumbers[$currentEl]++;
    }
}

$keys = array_keys($countNumbers);
sort($keys);

foreach ($keys as $key) {
    echo "$key => $countNumbers[$key]".PHP_EOL;
}
?>